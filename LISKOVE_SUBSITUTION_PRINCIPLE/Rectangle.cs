namespace Solid_Principles.LISKOVE_SUBSITUTION_PRINCIPLE
{
        public class Rectangle
        {   

            // age virtual nabashe subclass hash nmitonan overwritesh konan
            // bayad new konan azash va vaghti new konan bayad joftesho set konan
            // masalan baraye square bayad ham width ham height ro set konim :)) ke maskhasar
            public virtual int Width {get; set;}
            public virtual int Height {get; set;}
            public Rectangle(int width , int height)
            {
                Width = width ;
                Height = height ;
            }

            public Rectangle()
            {

            }

            public override string ToString()
            {
                return $"{nameof(Width)}: {Width} , {nameof(Height)}: {Height}";
            }
        }
}