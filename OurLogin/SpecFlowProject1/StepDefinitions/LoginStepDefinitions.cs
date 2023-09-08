namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class UserLoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Code to navigate to the login page
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            // Code to enter valid username and password
        }
        [When(@"I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            // Code to enter invalid credentials
        }


        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // Code to trigger the login action
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            // Code to verify successful login
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Code to verify the presence of an error message
        }
    }
}