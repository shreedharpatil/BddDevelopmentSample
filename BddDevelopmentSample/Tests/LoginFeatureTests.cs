using BddDevelopmentSample.Login;
using BddDevelopmentSample.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTalk.SpecFlow;

namespace BddDevelopmentSample.Tests
{
    [Binding]
    public class LoginFeatureTests
    {
        private LoginModel model;
        private ILoginProvider loginProvider;
        public LoginFeatureTests()
        {
            model = new LoginModel();
            loginProvider = new LoginProvider();
        }

        [Given(@"I have entered username in username field")]
        public void GivenIHaveEnteredUsernameInUsernameField()
        {
            model.Username = "Test";
        }

        [Given(@"I have entered password in password field")]
        public void GivenIHaveEnteredPasswordInPasswordField()
        {
            model.Password = "Test";
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            this.loginProvider.Login(model);
        }

        [Then(@"system should validate entered credentials and home page should be displayed")]
        public void ThenSystemShouldValidateEnteredCredentialsAndHomePageShouldBeDisplayed()
        {
            Assert.AreEqual("Success", model.Message);
        }

        [Given(@"I have entered invalid username in username field")]
        public void GivenIHaveEnteredInvalidUsernameInUsernameField()
        {
            model.Username = "Invalid usename";
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            this.loginProvider.Login(model);
        }
        
        [Then(@"system should validate entered credentials and show username invalid error messages")]
        public void ThenSystemShouldValidateEnteredCredentialsAndShowUsernameInvalidErrorMessages()
        {
            Assert.AreEqual("Invalid Username", model.Message);
        }      
    }
}