using System;
using System.Collections;
using System.Configuration;

namespace Actemium.WiSSWizard
{
  public sealed class ConfigHandlerNavigation : ConfigurationSection
  {
    public ConfigHandlerNavigation()
    {
    }

    [ConfigurationProperty("TabItems")]
    public NavigationTabItemCollection TabItems
    {
      get { return (NavigationTabItemCollection)this["TabItems"]; }
    }
  }

  public sealed class NavigationTabItemCollection : ConfigurationElementCollection
  {
    protected override ConfigurationElement CreateNewElement()
    {
      return new NavigationTabItem();
    }
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((NavigationTabItem)element).Name;
    }
    public override ConfigurationElementCollectionType CollectionType
    {
      get { return ConfigurationElementCollectionType.BasicMap; }
    }
    protected override string ElementName
    {
      get { return "TabItem"; }
    }
    public new NavigationTabItem this[string name]
    {
      get
      {
        IEnumerator enumerator = this.GetEnumerator();
        while (enumerator.MoveNext())
        {
          NavigationTabItem item = (NavigationTabItem)enumerator.Current;
          if (item.Name == name)
            return item;
        }
        return null;
      }
    }
    public bool ContainsKey(int key)
    {
      bool result = false;
      object[] keys = BaseGetAllKeys();
      foreach (object obj in keys)
      {
        if ((int)obj == key)
        {
          result = true;
          break;
        }
      }
      return result;
    }
  }

  public sealed class NavigationTabItem : ConfigurationElementCollection
  {
    public NavigationTabItem()
    {
    }

    [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
    public string Name
    {
      get { return (string)base["name"]; }
      set { base["name"] = value; }
    }

    [ConfigurationProperty("keyTips", IsRequired = false, DefaultValue = "")]
    public string KeyTips
    {
      get { return (string)base["keyTips"]; }
      set { base["keyTips"] = value; }
    }

    [ConfigurationProperty("tag", IsRequired = false, DefaultValue = "")]
    public string Tag
    {
      get { return (string)base["tag"]; }
      set { base["tag"] = value; }
    }

    [ConfigurationProperty("image", IsRequired = false, DefaultValue = null)]
    public string Image
    {
      get { return (string)base["image"]; }
      set { base["image"] = value; }
    }

    [ConfigurationProperty("accessControlItem", IsRequired = false, DefaultValue = null)]
    public string ACI_string
    {
      get { return (string)base["accessControlItem"]; }
      set { base["accessControlItem"] = value; }
    }

    [ConfigurationProperty("displayOrder", IsRequired = false, DefaultValue = null)]
    public string DisplayOrder
    {
      get { return (string)base["displayOrder"]; }
      set { base["displayOrder"] = value; }
    }

    public string[] ACI
    {
      get 
      {
        if (ACI_string != null && ACI_string.Length > 0)
          return ACI_string.Split(';');
        else
          return null;
      }
      set 
      {
        if (value == null)
          ACI_string = "";
        else
          ACI_string = String.Join(";", value); 
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return new NavigationTabBar();
    }
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((NavigationTabBar)element).Name;
    }
    public override ConfigurationElementCollectionType CollectionType
    {
      get { return ConfigurationElementCollectionType.BasicMap; }
    }
    protected override string ElementName
    {
      get { return "TabBar"; }
    }
    public new NavigationTabBar this[string name]
    {
      get
      {
        IEnumerator enumerator = this.GetEnumerator();
        while (enumerator.MoveNext())
        {
          NavigationTabBar item = (NavigationTabBar)enumerator.Current;
          if (item.Name == name)
            return item;
        }
        return null;
      }
    }
    public bool ContainsKey(int key)
    {
      bool result = false;
      object[] keys = BaseGetAllKeys();
      foreach (object obj in keys)
      {
        if ((int)obj == key)
        {
          result = true;
          break;
        }
      }
      return result;
    }
    


    public override string ToString()
    {
      return string.Format("NavigationTabItem:Name='{0}',KeyTips='{1}',Tag='{2}',Image='{3}', TabBars='{4}', DisplayOrder='{5}'",
        this.Name, this.KeyTips, this.Tag, this.Image, this.Count, this.DisplayOrder);
    }
  }

  public sealed class NavigationTabBar : ConfigurationElementCollection
  {
    public NavigationTabBar()
    {
    }

    [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
    public string Name
    {
      get { return (string)base["name"]; }
      set { base["name"] = value; }
    }

    [ConfigurationProperty("showName", IsRequired = false, DefaultValue=false)]
    public bool ShowName
    {
      get { return (bool)base["showName"]; }
      set { base["showName"] = value; }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return new NavigationTabItem();
    }
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((NavigationTabItem)element).Name;
    }
    public override ConfigurationElementCollectionType CollectionType
    {
      get { return ConfigurationElementCollectionType.BasicMap; }
    }
    protected override string ElementName
    {
      get { return "TabItem"; }
    }
    public new NavigationTabItem this[string name]
    {
      get
      {
        IEnumerator enumerator = this.GetEnumerator();
        while (enumerator.MoveNext())
        {
          NavigationTabItem item = (NavigationTabItem)enumerator.Current;
          if (item.Name == name)
            return item;
        }
        return null;
      }
    }
    public bool ContainsKey(int key)
    {
      bool result = false;
      object[] keys = BaseGetAllKeys();
      foreach (object obj in keys)
      {
        if ((int)obj == key)
        {
          result = true;
          break;
        }
      }
      return result;
    }


    public override string ToString()
    {
      return string.Format("NavigationTabBar:Name='{0}', TabItems='{1}'",
        this.Name, this.Count);
    }
  }
}
