using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginLibrary;

namespace SpecFlowProjectUsLogin.StepDefinitions
{
    [Binding]
    public class LoginStepDefinition
    {

        private string userName=""; 
        private string passWord="";
        private string loginResult = "";
        private readonly ScenarioContext scenarioContext;
        private readonly UserLoginLibrary.Userlogin userlogin;

        public LoginStepDefinition(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            this.userlogin = new UserLoginLibrary.Userlogin();
        }

        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndValidPassword(string p0, string p1)
        {
            userName = p0;
            passWord = p1;
        }

      

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginResult=userlogin.Login(userName, passWord);
        }

        [Then(@"the result should Login Success")]
        public void ThenTheResultShouldLoginSuccess()
        {
            Assert.Equal("Login Success", loginResult);
        }

        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInValidPassword(string p0, string invalid)
        {
            userName = p0;
            passWord = invalid;
        }


        [Then(@"the result should Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            Assert.Equal("Login Failed", loginResult);
        }
    }
}
