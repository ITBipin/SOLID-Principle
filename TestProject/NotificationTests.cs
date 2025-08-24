namespace TestProject
{
    public class NotificationTests
    {
        //Violating SRP test cases
        [Fact]
        public void SendEmail_ShouldReturnExpectedMessage()
        {
            //Arrange
            var notification = new SOLID.SinglePrinciple.Notification();
            //Act
           var result= notification.SendEmail("Send Email");
            //Assert
            Assert.Equal("Send Email", result);
        }

        [Fact]
        public void SendEmail_ShouldNotReturnExpectedMessage()
        {
            //Arrange
            var notification = new SOLID.SinglePrinciple.Notification();
            //Act
            var result = notification.SendEmail("Test Email");
            //Assert
            Assert.Equal("Send Email", result);
        }

        [Fact]
        public void SaveToDatabase_ShouldNotReturnExpectedMessageSaveToDatabase_ShouldWriteToConsole()
        {
            //Arrange
            var notification = new SOLID.SinglePrinciple.Notification();
            //Act
            var result = notification.SaveToDatabase("Test Database");
            //Assert
            Assert.Equal("Save to Database", result);
        }

        [Fact]
        public void SaveToDatabase_ShouldReturnExpectedMessageSaveToDatabase_ShouldWriteToConsole()
        {
            //Arrange
            var notification = new SOLID.SinglePrinciple.Notification();
            //Act
            var result = notification.SaveToDatabase("Save to Database");
            //Assert
            Assert.Equal("Save to Database", result);
        }
    }
}
