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
        Login.flagNumberPhone = false;
        Login.flagEmail = false;
        Login.flagPassword = false;
        Login.flagNumberPhoneRestoreAccess = false;
        Login.flagEmailRestoreAccess = false;
        Login.flagPasswordRestoreAccess = false;
        Login.flagRepeatPasswordRestoreAccess = false;
        Profile.flagLogin = false;
        Profile.flagUserName = false;

    }
}