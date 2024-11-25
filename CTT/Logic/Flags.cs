namespace CTT;

public class Flags
{
    public void changeFlag()
    {
        InputLine line = new InputLine();
        Frame2.flagLName = false;
        Frame2.flagName = false;
        Frame2.flagPassword = false;
        Frame2.flagRepeatPassword = false;
        Frame2.flagNumberPhone = false;
        Frame2.flagEmail = false;
        Frame3.flagNumberPhone = false;
        Frame3.flagEmail = false;
        Frame4.flagNumberPhone = false;
        Frame4.flagEmail = false;
        Frame4.flagPassword = false;
        Frame4.flagNumberPhoneRestoreAccess = false;
        Frame4.flagEmailRestoreAccess = false;
        Frame4.flagPasswordRestoreAccess = false;
        Frame4.flagRepeatPasswordRestoreAccess = false;
     /*   if (Frame2.flagLName)
        {
 
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
                
        }
        else if (Frame2.flagName)
        {
            Frame2.flagLName = false;
  
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else if (Frame2.flagPassword)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
      
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else if (Frame2.flagRepeatPassword)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
          
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else if (Frame2.flagNumberPhone)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
       
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
            
        }
        else  if (Frame2.flagEmail)
        {
          
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
     
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else   if (Frame3.flagNumberPhone)
        {
          
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
    
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else   if (Frame3.flagEmail)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;

            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else  if(Frame4.flagNumberPhone)
        {
            
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
         
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
          
        }
        else   if(Frame4.flagEmail)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
        
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else  if(Frame4.flagPassword)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
      
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        }
        else if(Frame4.flagNumberPhoneRestoreAccess)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
          
            Frame4.flagEmailRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        
        }
        else  if(Frame4.flagEmailRestoreAccess)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        
        
        }
        else  if(Frame4.flagPasswordRestoreAccess)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = true;
            Frame4.flagRepeatPasswordRestoreAccess = false;
        
        
        }
        else  if(Frame4.flagRepeatPasswordRestoreAccess)
        {
            Frame2.flagLName = false;
            Frame2.flagName = false;
            Frame2.flagPassword = false;
            Frame2.flagRepeatPassword = false;
            Frame2.flagNumberPhone = false;
            Frame2.flagEmail = false;
            Frame3.flagNumberPhone = false;
            Frame3.flagEmail = false;
            Frame4.flagNumberPhone = false;
            Frame4.flagEmail = false;
            Frame4.flagPassword = false;
            Frame4.flagNumberPhoneRestoreAccess = false;
            Frame4.flagPasswordRestoreAccess = false;
            Frame4.flagRepeatPasswordRestoreAccess = true;
        
        
        }*/
      //  line.LineParametr();
    }
}