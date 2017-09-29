using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;

namespace UnitTestProject1
{
    public static class DatabaseTestLoader
    {
        public static bool DatabaseDeployed;

        public static bool Load()
        {
            if (DatabaseDeployed)
            {
                return true;
            }

            var projects = ProjectCollection.GlobalProjectCollection;
            projects.SetGlobalProperty("Configuration", "Debug");
            projects.SetGlobalProperty("SqlPublishProfilePath", "Database1.publish.xml");

            var target = new[] { "Publish" };

            Project mySqlProject = projects.LoadProject(@"..\..\..\Database1\Database1.sqlproj");

            var result = mySqlProject.Build(target);

            return result;
        }
    }
}
