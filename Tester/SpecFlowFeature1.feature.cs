﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tester
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SpecFlowFeature1Feature : Xunit.IUseFixture<SpecFlowFeature1Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        public SpecFlowFeature1Feature()
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            this.TestInitialize();
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", "Test ignored tags for xunit", ProgrammingLanguage.CSharp, new string[] {
                        "IgnoreLocally"});
            testRunner.OnFeatureStart(featureInfo);
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
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SpecFlowFeature1Feature.FixtureData fixtureData)
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [McKeltCustom.SpecflowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Long running test should be ignored")]
        public virtual void LongRunningTestShouldBeIgnored()
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Long running test should be ignored", new string[] {
                        "LongRunningTest"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("this is a long running test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I only want to run this occassionally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I remove the tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("this test should be ignored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [McKeltCustom.SpecflowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Only run this on the build server")]
        public virtual void OnlyRunThisOnTheBuildServer()
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only run this on the build server", new string[] {
                        "IgnoreLocally"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I only run this on the build server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.Then("it should be ignored locally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [McKeltCustom.SpecflowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "Dont run this locally")]
        public virtual void DontRunThisLocally()
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dont run this locally", new string[] {
                        "IgnoreLocally"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I am running this locally", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.Then("this should be ignored", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [McKeltCustom.SpecflowPlugin.OptionallyIgnoreTestFactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Xunit.TraitAttribute("Description", "SomeOtherTag")]
        public virtual void SomeOtherTag()
        {
            if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
            {
                // If condition is true, execute these statements.
            }
            else
            {
                // Else block. If condition is false, execute these statements.
            return;
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SomeOtherTag", new string[] {
                        "SomeOtherTag"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I run some other tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.Then("it should always run the test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SpecFlowFeature1Feature.FeatureSetup();
                if (McKeltCustom.SpecflowPlugin.Settings.ShouldIgnoreLocally())
                {
                    // If condition is true, execute these statements.
                }
                else
                {
                    // Else block. If condition is false, execute these statements.
            return;
                }
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
