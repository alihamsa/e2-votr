using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Votr.DAL
{
    public class VotrRepository
    {
        VotrContext context { get; set}

        public VotrRepository()
        {
            //we need an instance of a Context
            context = new VotrContext();
        }

        [TestMethod]
        public void RepoEnsurePollCountIsZero()
        {
            //Arrange
            VotrRepository repo = new VotrRepository();

            //Act
            int expected = 0;
            int actual = 
        }
    }
}