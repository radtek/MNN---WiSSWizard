#region ****************************** Execution started - TreeNode: Shares ******************************
function func_Shares()
{
Add-AdminConsoleShareNode
}

function action()
{
$result = Show-MessageBox -Text 'Are you sure you want to remove the selected share(s)?' -Caption 'Remove Share' -Buttons 'YesNo' -Icon 'Question'
if ($result -eq [System.Windows.Forms.DialogResult]::Yes) {
	$input | ForEach-Object {
		$_.Delete()
	}
}
}


 func_Shares | where { $_.Name -eq 'Man$'} | action 
#endregion ****************************** Execution completed - TreeNode: Shares ******************************
