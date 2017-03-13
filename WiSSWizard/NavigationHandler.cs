using System;
using System.Drawing;
using System.Windows.Forms;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
	public enum NavigationItems
	{
    Help = -100, // Not pages, but seperate handling

		Error = -999,
		NoSelection = -1,
		Home = 10,

    Page1 = 101,
    Page2 = 102
	}

	class NavigationHandler
	{
		const string CLASSNAME = "NavigationHandler";

		public static MainForm MainForm;
		public static Panel TrgPanel;
		public static NavigationItems CurrentPage = NavigationItems.NoSelection;

		static public Boolean Navigate(NavigationItems navigationItem)
		{
			Trace.WriteInformation("({0})", "Navigate", CLASSNAME, navigationItem);
			
			if (TrgPanel == null)
				throw new Exception("TrgPanel was not set");

			return Navigate(navigationItem, TrgPanel);
		}
		static public Boolean Navigate(NavigationItems navigationItem, Panel targetPanel)
		{
			Trace.WriteInformation("({0}, {1})", "Navigate", CLASSNAME, navigationItem, targetPanel.Name);

      try
      {
        MainForm.ShowBusyBox = true;

        return DoNavigate(navigationItem, targetPanel);
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0}, {1})", "Navigate", CLASSNAME, ex, navigationItem, targetPanel.Name);

        DoNavigate(NavigationItems.Error, targetPanel);

        return false;
      }
			finally
			{
				MainForm.ShowBusyBox = false;
			}
		}

		static public Boolean DoNavigate(NavigationItems navigationItem, Panel targetPanel)
		{
			try
			{
				Trace.WriteVerbose("({0}, {1})", "DoNavigate", CLASSNAME, navigationItem, targetPanel.Name);

				Int32 controlIndex = -1;
				for (Int32 i = 0; i < targetPanel.Controls.Count; i++)
				{
					if (((BaseFormPage)targetPanel.Controls[i]).NavigationItem == navigationItem)
					{
						controlIndex = i;
						break;
					}
				}

				Trace.WriteVerbose("Found ControlIndex: {0}", "DoNavigate", CLASSNAME, controlIndex);

				if (controlIndex < 0)
				{
					try
					{
						if (MainForm == null)
							throw new Exception("MainForm was not set");

						Trace.WriteVerbose("Creating new control.", "DoNavigate", CLASSNAME, controlIndex);

						BaseFormPage screenControl = GetControlScreen(navigationItem);
						if (screenControl != null)
						{
							screenControl.mainForm = MainForm;
							targetPanel.Controls.Add((Control)screenControl);
							controlIndex = targetPanel.Controls.Count - 1;

							Trace.WriteVerbose("Added control on index: {0}", "DoNavigate", CLASSNAME, controlIndex);
						}
					}
					catch (Exception ex)
					{
						Trace.WriteError("Failed to create and open screencontrol: {0}", "DoNavigate", CLASSNAME, ex, navigationItem);
						throw;
					}
				}

				for (Int32 i = 0; i < targetPanel.Controls.Count; i++)
				{
					if (((BaseFormPage)targetPanel.Controls[i]).IsActivated)
					{
						Trace.WriteVerbose("Control hidden: {0}:{1}", "DoNavigate", CLASSNAME, controlIndex, ((BaseFormPage)targetPanel.Controls[i]).NavigationItem);
						((BaseFormPage)targetPanel.Controls[i]).Hide();
						((BaseFormPage)targetPanel.Controls[i]).DeActivateFromMain();
					}
				}

				if (controlIndex > -1)
				{

					BaseFormPage resultScreen = (BaseFormPage)targetPanel.Controls[controlIndex];

					resultScreen.ActivateFromMain();
					targetPanel.Controls[controlIndex].Size = new Size(targetPanel.Width, targetPanel.Height);
					targetPanel.Controls[controlIndex].Show();
					targetPanel.Controls[controlIndex].Dock = DockStyle.Fill;
					resultScreen.GiveFocusFromMain();
					resultScreen.RefreshFromMain();
					if (resultScreen.NavigationItem != NavigationItems.NoSelection && resultScreen.NavigationItem != NavigationItems.Home)
						CurrentPage = resultScreen.NavigationItem;

					Trace.WriteVerbose("Control activated: {0}:{1}", "DoNavigate", CLASSNAME, controlIndex, ((BaseFormPage)targetPanel.Controls[controlIndex]).NavigationItem);

					return true;
				}
				else
					return false;
			}
			catch (Exception ex)
			{
				Trace.WriteError("({0}, {1})", "DoNavigate", CLASSNAME, ex, navigationItem, targetPanel.Name);
				throw;
			}
		}

		static private BaseFormPage GetControlScreen(NavigationItems navigationItem)
		{
			try
			{
				switch (navigationItem)
				{											
					case NavigationItems.NoSelection:
					case NavigationItems.Home:
						return (BaseFormPage)new CtrlHome();            
					case NavigationItems.Error:
						return (BaseFormPage)new CtrlError(true);

					default:
						return (BaseFormPage)new CtrlError(false);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteError("({0})", "GetControlScreen", CLASSNAME, ex, navigationItem);
					throw;
			}
		}
	}
}
