namespace övn3
{
    class UnsuccessfulInput : UserError
    {
        
        public override string UEMessage()
        {
            return "The input was unsuccessful. This fired an error!";
        }

    }

}
