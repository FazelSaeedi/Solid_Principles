namespace Solid_Principles.LISKOVE_SUBSITUTION_PRINCIPLE
{
    public class Square : Rectangle
        {
            public override int Width
            {
                set { base.Width = base.Height = value ; }
            }

            public override int Height
            {
                set { base.Width = base.Height = value ; }
            }
        }
}