using System;
using System.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using AirticketApp.Models;
using Microsoft.Owin.Security.Twitter;
using Owin.Security.Providers.LinkedIn;

namespace AirticketApp
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.  
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });            
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // Enables the application to remember the second login verification factor such as phone or email.
            // Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
            // This is similar to the RememberMe option when you log in.
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "YHY4Wixcen6Urv1kVeUVQyvJs",
            //   consumerSecret: "7PdN1RXzBMuu8UWtUpSh9IYkxkKnSUGRYtvfHfhMzm4TRWw5uD");
            app.UseTwitterAuthentication(new TwitterAuthenticationOptions
            {
                ConsumerKey = ConfigurationManager.AppSettings["TwitterConsumerKey"],
                ConsumerSecret = ConfigurationManager.AppSettings["TwitterConsumerSecret"],
                BackchannelCertificateValidator =
                    new Microsoft.Owin.Security.CertificateSubjectKeyIdentifierValidator(new[]
                    {
                        ConfigurationManager.AppSettings["key1"], // VeriSign Class 3 Secure Server CA - G2
                        ConfigurationManager.AppSettings["key2"], // VeriSign Class 3 Secure Server CA - G3
                        ConfigurationManager.AppSettings["key3"],
                        // VeriSign Class 3 Public Primary Certification Authority - G5
                        ConfigurationManager.AppSettings["key4"], // Symantec Class 3 Secure Server CA - G4
                        ConfigurationManager.AppSettings["key5"], // Symantec Class 3 EV SSL CA - G3
                        ConfigurationManager.AppSettings["key6"], // VeriSign Class 3 Primary CA - G5
                        ConfigurationManager.AppSettings["key7"], // DigiCert SHA2 High Assurance Server C‎A 
                        ConfigurationManager.AppSettings["key8"] // DigiCert High Assurance EV Root CA
                    })
            });

            //app.UseFacebookAuthentication(
            //   appId: "1707917546137520",
            //   appSecret: "0e8955e2d9c7ee657933b13855dacf40");

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = ConfigurationManager.AppSettings["GooglePlusClientId"],
                ClientSecret = ConfigurationManager.AppSettings["GooglePlusClientSecret"]
            });

            app.UseLinkedInAuthentication(new LinkedInAuthenticationOptions()
            {
                ClientId = ConfigurationManager.AppSettings["LinkedInClientId"],
                ClientSecret = ConfigurationManager.AppSettings["LinkedInClientSecret"]
            });
        }
    }
}