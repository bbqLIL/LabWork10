public class LabWork10Test
{
    //tests
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("pass4wo")]
    [InlineData("password")]
    [InlineData("12345678")]
    public void ValidationPassword_ReturnFalse(string? password)
    {
        Assert.False(PasswordValidation.ValidationPassword(password));
    }

    [Fact]
    public void ValidationPassword_ReturnTrue()
    {
        Assert.True(PasswordValidation.ValidationPassword("Password2"));
    }
}