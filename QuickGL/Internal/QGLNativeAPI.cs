namespace QuickGLNS.Internal
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    internal class QGLNativeAPI : Attribute
    {
        public string Name { get; private set; }
        
        public QGLNativeAPI(string name)
        {
            Name = name;
        }
    }
}