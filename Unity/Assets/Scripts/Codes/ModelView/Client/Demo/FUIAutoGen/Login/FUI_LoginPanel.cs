/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.Login
{
	public partial class FUI_LoginPanel: GComponent
	{
		public enum c1_Page
		{
			Page_State1,
			Page_State2,
		}

		public Controller c1;
		public Controller c2;
		public GButton LoginBtn;
		public ET.Client.Common.FUI_InputField1 AccountInput;
		public ET.Client.Common.FUI_InputField1 PasswordInput;
		public const string URL = "ui://rgfb0w498omm0";

		public static FUI_LoginPanel CreateInstance()
		{
			return (FUI_LoginPanel)UIPackage.CreateObject("Login", "LoginPanel");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			c1 = GetControllerAt(0);
			c2 = GetControllerAt(1);
			LoginBtn = (GButton)GetChildAt(1);
			AccountInput = (ET.Client.Common.FUI_InputField1)GetChildAt(2);
			PasswordInput = (ET.Client.Common.FUI_InputField1)GetChildAt(3);
		}
	}
}
