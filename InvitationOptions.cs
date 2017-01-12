namespace Banana_Chess
{
    internal class InvitationOptions
    {
        // colors of figures chosen depends one from the other. see setters getters to see the dependency
        private bool white;
        private bool black;
        private bool anyColor;  //default choice

        // clock options depends one from the other. see setters/getters to see dependency
        private bool time15min;
        private bool time30min;
        private bool time45min;
        private bool time60min;
        private bool noTime;         //default choise

        internal InvitationOptions()
        {
            ResetToDefault();   //use a method here to avoid defining two states diferent default states in two difeerent places in the program
        }

        internal ColorsInvOptions ColorPreffered
        {  // make sure throught tests the dependency between color options is mantained
            get
            {
                if (anyColor) return ColorsInvOptions.anyColor;
                else if (white) return ColorsInvOptions.white;
                else return ColorsInvOptions.black;
            }
            //the logic for the switching of the colors was moved from Form to here
            set
            {
                if (value == ColorsInvOptions.anyColor)
                {
                    if (!anyColor)
                    {
                        white = false;
                        black = false;
                        anyColor = true;
                    }
                    //else
                    //{
                        //unsetting anyColor is not allowed
                    //}
                }
                else
                {
                    if (value == ColorsInvOptions.white)
                    {
                        white = !white;
                        if (white) black = false;
                    }
                    else if (value == ColorsInvOptions.black)
                    {
                        black = !black;
                        if (black) white = false;
                    }
                    else
                    {
                        // execution flow should never reach this point, because InvitationOptions has no more options
                        throw new System.ArgumentException("The value of ColorInvOptions passed to InvitationOptions class is not expected.\n" +
                                                           "Maybe you changed the possible values to the enum ColorInvOptions.\n" +
                                                           "If so, please add the code to attend such case.");
                    }
                    if (!black && !white)
                        anyColor = true;
                    else
                        anyColor = false;
                }
            }
        }

        internal string TimePrefferedOut
        {
            get {
                return 
                  (time15min ? "1" : "0") +
                  (time30min ? "1" : "0") +
                  (time45min ? "1" : "0") +
                  (time60min ? "1" : "0") +
                  (noTime ? "1" : "0");
                }
        }

        internal TimeInvOptions TimePrefferedIn
        {   // manatain the correct dependency between time options with proper tests

                // NOTE:   get   should return collection

            set
            {
                if (value == TimeInvOptions.noTime)
                {
                    noTime = true;
                    time15min = false;
                    time30min = false;
                    time45min = false;
                    time60min = false;
                }
                else
                {
                    switch (value)
                    {
                        case TimeInvOptions.time15min:
                            time15min = !time15min;
                            break;
                        case TimeInvOptions.time30min:
                            time30min = !time30min;
                            break;
                        case TimeInvOptions.time45min:
                            time45min = !time45min;
                            break;
                        case TimeInvOptions.time60min:
                            time60min = !time60min;
                            break;
                        default:
                            // execution flow should never reach this point, because TimeInvOptions has no more options
                            throw new System.ArgumentException("The value of TimeInvOptions passed to InvitationOptions class is not expected.\n" +
                                                           "Maybe you changed the possible values to the enum TimeInvOptions.\n" +
                                                           "If so, please add the code to attend such case.");
                    }
                    if (!time15min && !time30min && !time45min && !time60min)
                        noTime = true;
                    else
                        noTime = false;
                }
            }
        }
        
        internal void copyInvOptions(InvitationOptions toCopy)
        {
            white = toCopy.white;
            black = toCopy.black;
            anyColor = toCopy.anyColor;
            time15min = toCopy.time15min;
            time30min = toCopy.time30min;
            time45min = toCopy.time45min;
            time60min = toCopy.time60min;
            noTime = toCopy.noTime;
        }

        internal bool getAtIndex(int i)
        {
            switch (i)
            {
                case 0:
                    return white;
                case 1:
                    return black;
                case 2:
                    return anyColor;
                case 3:
                    return time15min;
                case 4:
                    return time30min;
                case 5:
                    return time45min;
                case 6:
                    return time60min;
                case 7:
                    return noTime;
                default:
                    return false; // sillently ignore bad index passed as argument
            }
        }

        internal void fromStr(string optToCopy)
        { //note above is swithing and here is copying values
            ColorPreffered = (ColorsInvOptions)int.Parse(optToCopy.Substring(0, 1));
            time15min = optToCopy[1] == '1' ? true : false;
            time30min = optToCopy[2] == '1' ? true : false;
            time45min = optToCopy[3] == '1' ? true : false;
            time60min = optToCopy[4] == '1' ? true : false;
            noTime = optToCopy[5] == '1' ? true : false;
        }

        internal void ResetToDefault()
        {
            white = false;
            black = false;
            anyColor = true;
            
            time15min = false;
            time30min = false;
            time45min = false;
            time60min = false;
            noTime = true;
        }
    }
}
