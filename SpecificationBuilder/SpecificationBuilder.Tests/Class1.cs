using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SpecificationBuilder.Specifications;

namespace SpecificationBuilder.Tests
{
    [TestFixture]
    public class EnumerateSpecifications
    {

        [Test]
        public void EnumerateTwoSpecifications()
        {
            var postCodeStartsWithSpecification = new PostCodeStartsWithSpecification();
            var postCodeEndsWithSpecification = new PostCodeStartsWithSpecification();

             new SpecificationAggregate<>()
            
        }
    }
}
