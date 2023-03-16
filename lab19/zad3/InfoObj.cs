namespace p1
{
    class InfoObj
    {
        public static void Info<tip>(tip obj)
            where tip : Nedelya
        {
            obj.PrintNedelya();
        }
    }
}
