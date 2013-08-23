using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SppLauncher.Class
{
    internal static class AssemblyResolver
    {
        /// <summary>
        /// Call in the static constructor of the startup class.
        /// </summary>
        public static void Initialize()
        {
            AppDomain.CurrentDomain.AssemblyResolve +=
                new ResolveEventHandler(Resolver);
        }


        /// <summary>
        /// Use this to resolve assemblies.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            if (args.Name == null)
                throw new NullReferenceException(
                    "Item name is null and could not be resolved."
                    );
            if (!executingAssembly.GetManifestResourceNames().Contains(
                "Many_Objects_Display.Resources." +
                new AssemblyName(args.Name).Name.Replace(".resources", ".dll"))
                )
                throw new ArgumentException("Resource name does not exist.");

            Stream resourceStream =
                executingAssembly.GetManifestResourceStream(
                    "Many_Objects_Display.Resources." +
                    new AssemblyName(args.Name).Name.Replace(".resources", ".dll")
                    );
            if (resourceStream == null)
                throw new NullReferenceException("Resource stream is null.");
            if (resourceStream.Length > 104857600)
                throw new ArgumentException(
                    "Exceedingly long resource - greater than 100 MB. Aborting..."
                    );

            byte[] block = new byte[resourceStream.Length];
            resourceStream.Read(block, 0, block.Length);

            Assembly resourceAssembly = Assembly.Load(block);
            if (resourceAssembly == null)
                throw new NullReferenceException("Assembly is a null value.");
            return resourceAssembly;
        }
    }
}