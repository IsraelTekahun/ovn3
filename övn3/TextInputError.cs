namespace övn3
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired an error!";
        }

    }

}
