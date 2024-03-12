/* 
 * Revenium Metering API
 *
 * Revenium Metering API
 *
 * OpenAPI spec version: 1.14.0-SNAPSHOT
 * Contact: info@revenium.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.io.revenium;
using IO.Swagger.io.revenium;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MetringApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MetringApiTests
    {
        private MetringApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MetringApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MetringApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MetringApi
            //Assert.IsInstanceOfType(typeof(MetringApi), instance, "instance is a MetringApi");
        }

        /// <summary>
        /// Test Meter
        /// </summary>
        [Test]
        public void MeterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MeteringRequestDTO body = null;
            //var response = instance.Meter(body);
            //Assert.IsInstanceOf<Unit> (response, "response is Unit");
        }
        /// <summary>
        /// Test Valid
        /// </summary>
        [Test]
        public void ValidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productKey = null;
            //string application = null;
            //var response = instance.Valid(productKey, application);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
