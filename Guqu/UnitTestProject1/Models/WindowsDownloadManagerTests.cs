﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guqu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guqu.Models.Tests
{
    [TestClass()]
    public class WindowsDownloadManagerTests
    {
        [TestMethod()]
        public void WindowsDownloadManagerTest()
        {
            try
            {
                WindowsDownloadManager win = new WindowsDownloadManager();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void downloadFileTest()
        {
            
        }
    }
}