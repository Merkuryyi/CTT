namespace CTT.Frame;

public class Flags
{
    public void changeFlag()
    {
        Registration.flagUserName = false;
        Registration.flagLogin = false;
        Registration.flagPassword = false;
        Registration.flagRepeatPassword = false;
        Registration.flagNumberPhone = false;
        Registration.flagEmail = false;
        ConfirmationRegistration.flagNumberPhone = false;
        ConfirmationRegistration.flagEmail = false;
        LogIn.flagNumberPhone = false;
        LogIn.flagEmail = false;
        LogIn.flagPassword = false;
        LogIn.flagNumberPhoneRestoreAccess = false;
        LogIn.flagEmailRestoreAccess = false;
        LogIn.flagPasswordRestoreAccess = false;
        LogIn.flagRepeatPasswordRestoreAccess = false;
        Profile.flagLogin = false;
        Profile.flagUserName = false;

    }
}