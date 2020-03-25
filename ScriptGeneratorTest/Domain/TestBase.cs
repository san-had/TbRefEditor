using System;
using Ninject;
using ScriptGeneration;

namespace ScriptGeneratorTest.Domain
{
    public abstract class TestBase : IDisposable
    {
        private bool disposed = false;

        public TestBase()
        {
            Kernel = new StandardKernel();
            Kernel.Load<ScriptGeneratorNinjectModule>();
        }

        protected IKernel Kernel { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Kernel.Dispose();
            }

            disposed = true;
        }
    }
}