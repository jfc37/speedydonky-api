﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace IntegrationTests.Features.Reports
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TeacherInvoices")]
    public partial class TeacherInvoicesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TeacherInvoices.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TeacherInvoices", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate teacher invoices report - solo teacher")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        public virtual void GenerateTeacherInvoicesReport_SoloTeacher()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate teacher invoices report - solo teacher", new string[] {
                        "teacher_invoices",
                        "reports"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("the default solo teacher rate is \'10.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("a block with \'2\' classes exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("the block has \'1\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When("the teacher invoice report is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the request is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.And("the teacher invoice report has \'1\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("the teacher invoice report totals \'20\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate teacher invoices report - partnered teacher")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        public virtual void GenerateTeacherInvoicesReport_PartneredTeacher()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate teacher invoices report - partnered teacher", new string[] {
                        "teacher_invoices",
                        "reports"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
testRunner.Given("an existing user is a teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.Given("the default partnered teacher rate is \'20.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.And("a block with \'2\' classes exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("the block has \'2\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("the teacher invoice report is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("the request is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("the teacher invoice report has \'2\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("the teacher invoice report totals \'80\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate teacher invoices report - solo and partnered teacher")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        public virtual void GenerateTeacherInvoicesReport_SoloAndPartneredTeacher()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate teacher invoices report - solo and partnered teacher", new string[] {
                        "teacher_invoices",
                        "reports"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("the default partnered teacher rate is \'10.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("the default solo teacher rate is \'20.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("a teacher is teaching a solo block and a partnered block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("the teacher invoice report is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("the request is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.And("the teacher invoice report has \'2\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("the teacher invoice report totals \'80\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate teacher invoices report - event")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        public virtual void GenerateTeacherInvoicesReport_Event()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate teacher invoices report - event", new string[] {
                        "teacher_invoices",
                        "reports"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("a stand alone event with \'25\' teacher rate exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.When("the teacher invoice report is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the request is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("the teacher invoice report has \'1\' teacher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("the teacher invoice report totals \'25\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failed generate teacher invoices report - no dates provided")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        [NUnit.Framework.CategoryAttribute("validation_errors")]
        public virtual void FailedGenerateTeacherInvoicesReport_NoDatesProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed generate teacher invoices report - no dates provided", new string[] {
                        "teacher_invoices",
                        "reports",
                        "validation_errors"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.When("the teacher invoice report is requested with no dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the request is unsuccessful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Failed generate teacher invoices report - from date is after to date")]
        [NUnit.Framework.CategoryAttribute("teacher_invoices")]
        [NUnit.Framework.CategoryAttribute("reports")]
        [NUnit.Framework.CategoryAttribute("validation_errors")]
        public virtual void FailedGenerateTeacherInvoicesReport_FromDateIsAfterToDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed generate teacher invoices report - from date is after to date", new string[] {
                        "teacher_invoices",
                        "reports",
                        "validation_errors"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.When("the teacher invoice report is requested with from date being after to date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the request is unsuccessful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
