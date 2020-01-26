using System;
using System.Collections.Generic;
using System.Text;

using BlazorWebFormsComponents.Enums;
using BlazorWebFormsComponents.Validations;

using Microsoft.AspNetCore.Components;

namespace BlazorWebFormsComponents.LoginControls
{
	public partial class ChangePassword : BaseWebFormsComponent
	{

		#region Not Implemented yet
		public bool RenderOuterTable { get; set; }
		public object MailDefinition { get; set; }
		public object ChangePasswordTemplate { get; set; }

		#endregion

		[Parameter] public string NewPasswordRequiredErrorMessage { get; set; } = "New Password is required.";

		[Parameter] public string NewPasswordRegularExpression { get; set; }

		[Parameter] public string NewPasswordLabelText { get; set; } = "New Password:";

		[Parameter] public string NewPasswordRegularExpressionErrorMessage { get; set; } = "Please enter a different password.";

		[Parameter] public string HelpPageUrl { get; set; }

		[Parameter] public string HelpPageText { get; set; }

		[Parameter] public string HelpPageIconUrl { get; set; }

		[Parameter] public string EditProfileUrl { get; set; }

		[Parameter] public string EditProfileText { get; set; }

		[Parameter] public string EditProfileIconUrl { get; set; }

		[Parameter] public bool DisplayUserName { get; set; }

		[Parameter] public string InstructionText { get; set; }

		[Parameter] public string PasswordLabelText { get; set; } = "Password:";

		[Parameter] public string UserNameRequiredErrorMessage { get; set; } = "User Name is required.";

		[Parameter] public string UserNameLabelText { get; set; } = "Username:";

		[Parameter] public string SuccessTitleText { get; set; }

		[Parameter] public string PasswordHintText { get; set; }

		[Parameter] public string SuccessText { get; set; }

		[Parameter] public string SuccessPageUrl { get; set; }

		[Parameter] public string PasswordRequiredErrorMessage { get; set; }

		[Parameter] public string PasswordRecoveryUrl { get; set; }

		[Parameter] public string PasswordRecoveryText { get; set; }

		[Parameter] public string PasswordRecoveryIconUrl { get; set; }

		[Parameter] public string CreateUserText { get; set; }

		[Parameter] public string CreateUserUrl { get; set; }

		[Parameter] public string ContinueDestinationPageUrl { get; set; }

		[Parameter] public string CreateUserIconUrl { get; set; }

		[Parameter] public int BorderPadding { get; set; }

		[Parameter] public string CancelButtonImageUrl { get; set; }

		[Parameter] public string CancelButtonText { get; set; }

		[Parameter] public ButtonType CancelButtonType { get; set; }

		[Parameter] public string CancelDestinationPageUrl { get; set; }

		[Parameter] public string ChangePasswordButtonImageUrl { get; set; }

		[Parameter] public string ChangePasswordButtonText { get; set; }

		[Parameter] public string ChangePasswordFailureText { get; set; }

		[Parameter] public ButtonType ChangePasswordButtonType { get; set; }

		[Parameter] public ButtonType ContinueButtonType { get; set; }

		[Parameter] public string ContinueButtonText { get; set; }

		[Parameter] public string ContinueButtonImageUrl { get; set; }

		[Parameter] public string ConfirmPasswordRequiredErrorMessage { get; set; }

		[Parameter] public string ConfirmNewPasswordLabelText { get; set; } = "Confirm New Password:";

		[Parameter] public string ChangePasswordTitleText { get; set; } = "Change Your Password";

		[Parameter] public string ConfirmPasswordCompareErrorMessage { get; set; } = "The Confirm New Password must match the New Password entry.";

		[Parameter] public RenderFragment SuccessTemplate { get; set; }

		public string UserName { get; set; }
		public string NewPassword { get; set; }
		public string CurrentPassword { get; set; }
		public string ConfirmNewPassword { get; }

		private ChangePasswordModel Model { get; set; }

		#region Style
		[Parameter] public RenderFragment ChildContent { get; set; }

		[CascadingParameter(Name = "LabelStyle")]
		private TableItemStyle LabelStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "InstructionTextStyle")]
		private TableItemStyle InstructionTextStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "HyperLinkStyle")]
		private TableItemStyle HyperLinkStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "FailureTextStyle")]
		private TableItemStyle FailureTextStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "PasswordHintStyle")]
		private TableItemStyle PasswordHintStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "ValidatorTextStyle")]
		private Style ValidatorTextStyle { get; set; } = new Style();

		[CascadingParameter(Name = "TextBoxStyle")]
		private Style TextBoxStyle { get; set; } = new Style();

		[CascadingParameter(Name = "TitleTextStyle")]
		private TableItemStyle TitleTextStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "SuccessTextStyle")]
		private TableItemStyle SuccessTextStyle { get; set; } = new TableItemStyle();

		[CascadingParameter(Name = "CancelButtonStyle")]
		private Style CancelButtonStyle { get; set; } = new Style();

		[CascadingParameter(Name = "ChangePasswordButtonStyle")]
		private Style ChangePasswordButtonStyle { get; set; } = new Style();

		[CascadingParameter(Name = "ContinueButtonStyle")]
		private Style ContinueButtonStyle { get; set; } = new Style();

		#endregion

		private RequiredFieldValidator<string> UsernameValidator { get; set; }

		private RequiredFieldValidator<string> PasswordValidator { get; set; }
		private RequiredFieldValidator<string> NewPasswordValidator { get; set; }
		private RequiredFieldValidator<string> ConfirmNewPasswordValidator { get; set; }
	}
}