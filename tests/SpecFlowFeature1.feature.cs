﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace XUnit.OptionallyIgnore.Tester
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SpecFlowFeature1Feature : Xunit.IUseFixture<SpecFlowFeature1Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        public SpecFlowFeature1Feature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", "Test ignored tags for xunit", ProgrammingLanguage.CSharp, new string[] {
                        "OptionallyIgnore"});
            testRunner.OnFeatureStart(featureInfo);
//More info on this add-in available at
//https://github.com/chrismckelt/XUnit.OptionallyIgnore
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SpecFlowFeature1Feature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [XUnit.OptionallyIgnore.SpecFlowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Long running test should be ignored")]
        public virtual void LongRunningTestShouldBeIgnored()
        {
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.OptionallyIgnore = null;
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldTestRun("OptionallyIgnore");
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Long running test should be ignored", new string[] {
                        "OptionallyIgnore"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("this is a long running test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("I only want to run this occassionally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I remove the tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("this test should be ignored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [XUnit.OptionallyIgnore.SpecFlowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Only run this on the build server")]
        public virtual void OnlyRunThisOnTheBuildServer()
        {
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.OptionallyIgnore = null;
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldTestRun("OptionallyIgnore");
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only run this on the build server", new string[] {
                        "OptionallyIgnore"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I only run this on the build server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("it should be ignored locally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [XUnit.OptionallyIgnore.SpecFlowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Dont run this locally")]
        public virtual void DontRunThisLocally()
        {
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.OptionallyIgnore = null;
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldTestRun("OptionallyIgnore");
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dont run this locally", new string[] {
                        "OptionallyIgnore"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I am running this locally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("this should be ignored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [XUnit.OptionallyIgnore.SpecFlowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "SomeOtherTag")]
        public virtual void SomeOtherTag()
        {
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.OptionallyIgnore = null;
            XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldTestRun("SomeOtherTag");
            if (XUnit.OptionallyIgnore.SpecFlowPlugin.Settings.ShouldOptionallyIgnore())
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
            }
            else
            {
                // https://github.com/chrismckelt/XUnit.OptionallyIgnore
return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SomeOtherTag", new string[] {
                        "SomeOtherTag"});
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I run some other tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("it should always run the test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SpecFlowFeature1Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SpecFlowFeature1Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion