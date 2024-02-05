using KioskProject;

class CashBox {
    private decimal _oneHundreds = 0;
    private decimal _fifties = 0;
    private decimal _twenties = 0;
    private decimal _tens = 0;
    private decimal _fives = 0;
    private decimal _twos = 0;
    private decimal _ones = 0;

    private decimal _halfDollars = 0;
    private decimal _quarters = 0;
    private decimal _dimes = 0;
    private decimal _nickels = 0;
    private decimal _pennies = 0;

    //private double _totalInCashBox = 0;

    //Constructor
    public CashBox(decimal OneHundred, decimal Fifties, decimal Twenties, decimal Tens, decimal Fives, decimal Twos, decimal Ones, decimal HalfDollars, decimal Quarters, decimal Dimes, decimal Nickels, decimal Pennies ) {
        _oneHundreds = OneHundred;
        _fifties = Fifties;
        _twenties = Twenties;
        _tens = Tens;
        _fives = Fives;
        _twos = Twos;
        _ones = Ones;

        _halfDollars = HalfDollars;
        _quarters = Quarters;
        _dimes = Dimes;
        _nickels = Nickels;
        _pennies = Pennies;
    }//end Cashbox

    #region for GetSetQntyDenominations
    private decimal _oneHundredsQnty = 0;
    private decimal _fiftiesQnty = 0;
    private decimal _twentiesQnty = 0;
    private decimal _tensQnty = 0;
    private decimal _fivesQnty = 0;
    private decimal _twosQnty = 0;
    private decimal _onesQnty = 0;

    private decimal _halfDollarsQnty = 0;
    private decimal _quartersQnty = 0;
    private decimal _dimesQnty = 0;
    private decimal _nickelsQnty = 0;
    private decimal _penniesQnty = 0;
    #endregion for GetSetQntyDenominations

    public decimal OneHundreds {
        get { return _oneHundreds; }
        set { _oneHundreds = value;}
    }

    public decimal Fifties {
        get { return _fifties; } 
        set { _fifties = value;}
    }

    public decimal Twenties {
        get { return _twenties; }
        set { _twenties = value;}
    }

    public decimal Tens {
        get { return _tens; }
        set { _tens = value;}
    }

    public decimal Fives {
        get { return _fives; }
        set { _fives = value;}
    }
    public decimal Twos {
        get { return _twos; }
        set { _twos = value;}
    }

    public decimal Ones {
        get { return _ones; }
        set { _ones = value;}
    }

    public decimal HalfDollars {
        get { return _halfDollars; }
        set { _halfDollars = value;}
    }

    public decimal Quarters {
        get { return _quarters; }
        set { _quarters = value;}
    }

    public decimal Dimes {
        get { return _dimes; }
        set { _dimes = value;}
    }

    public decimal Nickels {
        get { return _nickels; }
        set { _nickels = value; }
    }

    public decimal Pennies {
        get { return _pennies; }
        set { _pennies = value; }
    }

    /*public double TotalInCashBox {
        get { return _totalInCashBox; }
        set { _totalInCashBox = OneHundreds + Fifties + Twenties + Tens + Fives + Ones + HalfDollars + Quarters + Dimes + Nickles + Pennies; }
    }*/

    public decimal GetTotalInCashBox() {
        GetQntyOneHundreds();
        GetQntyFifties();
        GetQntyTwenties();
        GetQntyTens();
        GetQntyFives();
        GetQntyTwos();
        GetQntyOnes();
        GetQntyHalfDollars();
        GetQntyQuarters();
        GetQntyDimes();
        GetQntyNickels();
        GetQntyPennies();
        return OneHundreds + Fifties + Twenties + Tens + Fives + Twos + Ones + HalfDollars + Quarters + Dimes + Nickels + Pennies;
        
    }


    //Quantities in each denominations

    public decimal GetQntyOneHundreds() {
        return _oneHundredsQnty = OneHundreds / 100;
    }

    public decimal GetQntyFifties() {
        return _fiftiesQnty = Fifties / 50;
    }

    public decimal GetQntyTwenties() {
        return _twentiesQnty = Twenties / 20;
    }

    public decimal GetQntyTens() {
        return _tensQnty = Tens / 10;
    }

    public decimal GetQntyFives() {
        return _fivesQnty = Fives / 5;
    }

    public decimal GetQntyTwos() {
        return _twosQnty = Twos / 10;
    }

    public decimal GetQntyOnes() {
        return _onesQnty = Ones / 1;
    }

    public decimal GetQntyHalfDollars() {
        return _halfDollarsQnty = HalfDollars / .50M;
    }

    public decimal GetQntyQuarters() {
        return _quartersQnty = Quarters / .25M;
    }

    public decimal GetQntyDimes() {
        return _dimesQnty = Dimes / .10M;
    }

    public decimal GetQntyNickels() {
        return _nickelsQnty = Nickels / .05M;
    }

    public decimal GetQntyPennies() {
        return _penniesQnty = Pennies / .01M;
    }

    #region GetSetQntyDenominations
    /*public int OneHundredsQnty {
        get { return _oneHundredsQnty; }
        set { _oneHundredsQnty = OneHundreds / 100; }
    }

    public int FiftiesQnty {
        get { return _fiftiesQnty; }
        set { _fiftiesQnty = Fifties / 50; }
    }

    public int TwentiesQnty {
        get { return _twentiesQnty; }
        set { _twentiesQnty = Twenties / 20; }
    }

    public int TensQnty {
        get { return _tensQnty; }
        set { _tensQnty = Tens / 10; }
    }

    public int FivesQnty {
        get { return _fivesQnty; }
        set { _fivesQnty = Fives / 5; }
    }

    public int TwosQnty {
        get { return _twosQnty; }
        set { _twosQnty = Twos / 2; }
    }

    public int OnesQnty {
        get { return _onesQnty; }
        set { _onesQnty = Ones / 1; }
    }

    public double HalfDollarsQnty {
        get { return _halfDollarsQnty; }
        set { _halfDollarsQnty = HalfDollars / .50;}
    }

    public double QuartersQnty {
        get { return _quartersQnty; }
        set { _quartersQnty = Quarters / .25; }
    }

    public double DimesQnty {
        get { return _dimesQnty;}
        set { _dimesQnty = Dimes / .10; }
    }

    public double NickelsQnty {
        get { return _nickelsQnty; }
        set { _nicklesQnty = Nickels / .05; }
    }

    public double PenniesQnty {
        get { return _penniesQnty;}
        set { _penniesQnty = Pennies / .01; }
    }*/
    #endregion GetSetQntyDenominations

    public void DispenseChange(decimal totalItemSum) {
        decimal remainingBalance = Math.Abs(totalItemSum);
        GetTotalInCashBox();

        //Calculate the number of each denomination to dispense
        decimal oneHundredsCountsNeeded = Math.Floor(Math.Min(remainingBalance / 100, _oneHundredsQnty));
        remainingBalance -= oneHundredsCountsNeeded * 100;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal fiftiesCountsNeeded = Math.Floor(Math.Min(remainingBalance / 50,  _fiftiesQnty));
        remainingBalance -= fiftiesCountsNeeded * 50;
        remainingBalance = Math.Round(remainingBalance, 2);


        decimal twentiesCountsNeeded = Math.Floor(Math.Min(remainingBalance / 20,  _twentiesQnty));
        remainingBalance -= twentiesCountsNeeded * 20;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal tensCountsNeeded = Math.Floor(Math.Min(remainingBalance / 10,  _tensQnty));
        remainingBalance -= tensCountsNeeded * 10;
        remainingBalance = Math.Round(remainingBalance, 2);


        decimal fivesCountsNeeded = Math.Floor(Math.Min(remainingBalance / 5,   _fivesQnty));
        remainingBalance -= fivesCountsNeeded * 5;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal twosCountsNeeded = Math.Floor(Math.Min(remainingBalance / 2,   _twosQnty));
        remainingBalance -= twosCountsNeeded * 2;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal onesCountsNeeded = Math.Floor(Math.Min(remainingBalance / 1,  _onesQnty));
        remainingBalance -= onesCountsNeeded * 1;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal halfDollarsCountsNeeded = Math.Floor(Math.Min(remainingBalance / .50M, _halfDollarsQnty));
        remainingBalance -= halfDollarsCountsNeeded * .50M;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal quartersCountsNeeded   = Math.Floor(Math.Min(remainingBalance / .25M, _quartersQnty));
        remainingBalance -= quartersCountsNeeded * .25M;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal dimesCountsNeeded = Math.Floor(Math.Min(remainingBalance / .10M, _dimesQnty));
        remainingBalance -= dimesCountsNeeded * .10M;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal nickelsCountsNeeded = Math.Floor(Math.Min(remainingBalance / .05M, _nickelsQnty));
        remainingBalance -= nickelsCountsNeeded * .05M;
        remainingBalance = Math.Round(remainingBalance, 2);

        decimal penniesCountsNeeded = Math.Floor(Math.Min(remainingBalance / .01M, _penniesQnty));
        remainingBalance -= penniesCountsNeeded * .01M;
        remainingBalance = Math.Round(remainingBalance, 2);

        bool refundPayments = false;

        //CHECK IF THERE IS ENOUGH CASH
        decimal totalChangeDispensed = 0;


        while (refundPayments == false) {
            if (remainingBalance > 0) {
                refundPayments = true;
                Console.WriteLine("Insufficent Funds");
      
                InsufficientFundsReturn();

                string PayWithCard = "";
                do {
                    PayWithCard = Input("Would you like to pay with a Card [Y/N]? : ");
                } while (PayWithCard != "Y" && PayWithCard != "N");
                    if (PayWithCard == "Y") {
                        Program.PaymentCard(totalItemSum);
                        Console.WriteLine();
                    } else if (PayWithCard == "N") {
                        Console.WriteLine();
                        Console.WriteLine("Transactions Canceled");
                        Console.WriteLine();
                        Program.CheckOut(totalItemSum);
                    }//end else if




                } else if (refundPayments == false) {

                
                //UPDATE THE DISPENSER QUANTITIES
                _oneHundredsQnty -= oneHundredsCountsNeeded;
                _fiftiesQnty -= fiftiesCountsNeeded;
                _twentiesQnty -= twentiesCountsNeeded;
                _tensQnty -= tensCountsNeeded;
                _fivesQnty -= fivesCountsNeeded;
                _twosQnty -= tensCountsNeeded;
                _onesQnty -= onesCountsNeeded;
                _halfDollarsQnty -= halfDollarsCountsNeeded;
                _quartersQnty -= quartersCountsNeeded;
                _dimesQnty -= dimesCountsNeeded;
                _nickelsQnty -= nickelsCountsNeeded;
                _penniesQnty -= penniesCountsNeeded;


          

            //DISPLAY THE DISPENSE CHANGE

                while (oneHundredsCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $100");
                    oneHundredsCountsNeeded--;
                    totalChangeDispensed += 100;
                }//end while

                while (fiftiesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $50");
                    fiftiesCountsNeeded--;
                    totalChangeDispensed += 50;
                }//end while

                while (twentiesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $20");
                    twentiesCountsNeeded--;
                    totalChangeDispensed += 20;
                }//end while

                while (tensCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $10");
                    tensCountsNeeded--;
                    totalChangeDispensed += 10;
                }//end while

                while (fivesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $5");
                    fivesCountsNeeded--;
                    totalChangeDispensed += 5;
                }//end while

                while (twosCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $2");
                    twosCountsNeeded--;
                    totalChangeDispensed += 2;
                }//end while

                while (onesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $1");
                    onesCountsNeeded--;
                    totalChangeDispensed += 1;
                }//end while

                while (halfDollarsCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $.50");
                    halfDollarsCountsNeeded--;
                    totalChangeDispensed += .50M;
                }//end while

                while (quartersCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $.25");
                    quartersCountsNeeded--;
                    totalChangeDispensed += .25M;
                }//end while

                while (dimesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $.10");
                    dimesCountsNeeded--;
                    totalChangeDispensed += .10M;
                }//end while

                while (nickelsCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $.05");
                    nickelsCountsNeeded--;
                    totalChangeDispensed += .05M;
                }//end while

                while (penniesCountsNeeded > 0) {
                    Console.WriteLine("Dispensed: $.01");
                    penniesCountsNeeded--;
                    totalChangeDispensed += .01M;
                }//end while

                Console.WriteLine();
                Console.WriteLine($"Total Change Dispensed: {totalChangeDispensed:C}");

                refundPayments = true;
            }//end if
        }//end outer while

    }//end DispenseChange



    public class PaymentTransaction {

        private decimal _oneHundredsRefund = 0;
        private decimal _fiftiesRefund = 0;
        private decimal _twentiesRefund = 0;
        private decimal _tensRefund = 0;
        private decimal _fivesRefund = 0;
        private decimal _twosRefund = 0;
        private decimal _onesRefund = 0;

        private decimal _halfDollarsRefund = 0;
        private decimal _quartersRefund = 0;
        private decimal _dimesRefund = 0;
        private decimal _nickelsRefund = 0;
        private decimal _penniesRefund = 0;

        public decimal OneHundredsRefund {
            get { return _oneHundredsRefund; }
            set { _oneHundredsRefund = value; }
        }

        public decimal FiftiesRefund {
            get { return _fiftiesRefund; }
            set { _fiftiesRefund = value; }
        }

        public decimal TwentiesRefund {
            get { return _twentiesRefund; }
            set { _twentiesRefund = value; }
        }

        public decimal TensRefund {
            get { return _tensRefund; }
            set { _tensRefund = value; }
        }

        public decimal FivesRefund {
            get { return _fivesRefund; }
            set { _fivesRefund = value; }
        }
        public decimal TwosRefund {
            get { return _twosRefund; }
            set { _twosRefund = value; }
        }

        public decimal OnesRefund {
            get { return _onesRefund; }
            set { _onesRefund = value; }
        }

        public decimal HalfDollarsRefund {
            get { return _halfDollarsRefund; }
            set { _halfDollarsRefund = value; }
        }

        public decimal QuartersRefund {
            get { return _quartersRefund; }
            set { _quartersRefund = value; }
        }

        public decimal DimesRefund {
            get { return _dimesRefund; }
            set { _dimesRefund = value; }
        }

        public decimal NickelsRefund {
            get { return _nickelsRefund; }
            set { _nickelsRefund = value; }
        }

        public decimal PenniesRefund {
            get { return _penniesRefund; }
            set { _penniesRefund = value; }
        }


    }//end PaymentTransaction


    public void InsufficientFundsReturn() {

        decimal totalRefund = 0;

        while (Program._transactionRefund.OneHundredsRefund > 0) {
            Program._cashBox.OneHundreds -= 100;
            Program._transactionRefund.OneHundredsRefund -= 100;
            Console.WriteLine($"Refund: $100");
            totalRefund += 100;
        }//end while
        
        while (Program._transactionRefund.FiftiesRefund > 0) {
            Program._cashBox.Fifties -= 50;
            Program._transactionRefund.FiftiesRefund -= 50;
            Console.WriteLine($"Refund: $50");
            totalRefund += 50;
        }//end while
        
        while (Program._transactionRefund.TwentiesRefund > 0) {
            Program._cashBox.Twenties -= 20;
            Program._transactionRefund.TwentiesRefund -= 20;
            Console.WriteLine($"Refund: $20");
            totalRefund += 20;
        }//end while
                
        while (Program._transactionRefund.TensRefund > 0) {
            Program._cashBox.Tens -= 10;
            Program._transactionRefund.TensRefund -= 10;
            Console.WriteLine($"Refund: $10");
            totalRefund += 10;
        }//end while
                        
        while (Program._transactionRefund.FivesRefund > 0) {
            Program._cashBox.Fives -= 5;
            Program._transactionRefund.FivesRefund -= 5;
            Console.WriteLine($"Refund: $5");
            totalRefund += 5;
        }//end while
                                
        while (Program._transactionRefund.TwosRefund > 0) {
            Program._cashBox.Twos -= 2;
            Program._transactionRefund.TwosRefund -= 2;
            Console.WriteLine($"Refund: $2");
            totalRefund += 2;
        }//end while
                                        
        while (Program._transactionRefund.OnesRefund > 0) {
            Program._cashBox.Ones -= 1;
            Program._transactionRefund.OnesRefund -= 1;
            Console.WriteLine($"Refund: $1");
            totalRefund += 1;
        }//end while
                                                
        while (Program._transactionRefund.HalfDollarsRefund > 0) {
            Program._cashBox.HalfDollars -= .50M;
            Program._transactionRefund.HalfDollarsRefund -= .50M;
            Console.WriteLine($"Refund: $.50");
            totalRefund += .50M;
        }//end while
                                                       
        while (Program._transactionRefund.QuartersRefund > 0) {
            Program._cashBox.Quarters -= .25M;
            Program._transactionRefund.QuartersRefund -= .25M;
            Console.WriteLine($"Refund: $.25");
            totalRefund += .25M;
        }//end while
                                                               
        while (Program._transactionRefund.DimesRefund > 0) {
            Program._cashBox.Dimes -= .10M;
            Program._transactionRefund.DimesRefund -= .10M;
            Console.WriteLine($"Refund: $.10");
            totalRefund += .10M;
        }//end while
                                                                       
        while (Program._transactionRefund.NickelsRefund > 0) {
            Program._cashBox.Nickels -= .05M;
            Program._transactionRefund.NickelsRefund -= .05M;
            Console.WriteLine($"Refund: $.05");
            totalRefund += .05M;
        }//end while
                                                                               
        while (Program._transactionRefund.PenniesRefund > 0) {
            Program._cashBox.Pennies -= .01M;
            Program._transactionRefund.PenniesRefund -= .01M;
            Console.WriteLine($"Refund: $.01");
            totalRefund += .01M;
        }//end while

        Console.WriteLine("------------");
        Console.WriteLine($"Total Refund: {totalRefund:C}");
        Console.WriteLine();

    }//end InsufficientFundsReturn()








    #region HELPER FUNCTION
    static void EndProgramLayout() {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("------------End of Program--------------");
        Console.WriteLine();
        Console.ResetColor();
    }//end EndProgramLayout

    static void Print(string message) {
        Console.Write(message);
    }//end helper subfunction Print
    static string Input(string message) {
        Console.Write(message);
        return Console.ReadLine();
    }//end help subfunction Input

    static decimal InputDecimal(string message) {
        string value = Input(message);
        return decimal.Parse(value);
    }//end helper subfunction Inputdecimal

    static double InputDouble(string message) {
        string value = Input(message);
        return double.Parse(value);
    }//end helper subfunction InputDouble

    static int InputInt(string message) {
        string value = Input(message);
        return int.Parse(value);
    }//end helper subfunction InputInt

    //------TRY PARSE------
    static int TryInputInt(string message) {
        //VARIABLES
        int parsedValue = 0;
        bool gotParsed = false;

        //VALIDATION LOOP UNTIL VALID INT HAS BEEN SUBMITTED
        do {
            gotParsed = int.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        //RETURN PARSED VALUE
        return parsedValue;
    }//end function TryInputInt - Parse Int

    static double TryInputDouble(string message) {
        double parsedValue = 0;
        bool gotParsed = false;

        do {
            gotParsed = double.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        return parsedValue;
    }//end function TryInputDouble

    static decimal TryInputDecimal(string message) {
        decimal parsedValue = 0;
        bool gotParsed = false;

        do {
            gotParsed = decimal.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        return parsedValue;
    }//end function TryInputDecimal



    #endregion HELPER FUNCTION


}//end CashBox


