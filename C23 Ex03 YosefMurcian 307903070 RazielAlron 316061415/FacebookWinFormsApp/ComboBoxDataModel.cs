﻿namespace BasicFacebookFeatures
{
    public class ComboBoxDataModel
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
