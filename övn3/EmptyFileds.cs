namespace övn3
{
    class EmptyFileds : UserError
    {

        public override string UEMessage()
        {
            return "Not all fields are filled. This fired an error!";
        }

    }

}
