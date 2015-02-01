// Copyright (c) Eugene Berdnikov. See License.txt in the project root for license information.

using System;
using System.Web.UI;

namespace RecaptchaWebFormSample
{
    public partial class Default : Page
    {
        protected async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (await Recaptcha1.VerifyIfSolvedAsync())
            {
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                lblMessage.Text = "Incorrect CAPTCHA response.";
            }
        }
    }
}