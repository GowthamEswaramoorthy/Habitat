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
namespace Sitecore.Feature.Demo.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class MockupOfExternalPageFeature : Xunit.IClassFixture<MockupOfExternalPageFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Mockup of External page.feature"
#line hidden
        
        public MockupOfExternalPageFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Mockup of External page", "In order to start a demo story from an external page\r\nAs a technical presales con" +
                    "sultant\r\nI want to be able to show a mockup of an external page, e.g. search eng" +
                    "ine page with adword links to a campaign on the website", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(MockupOfExternalPageFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Mockup of External page")]
        [Xunit.TraitAttribute("Description", "Demo_UC1_Show Google search engine mockup")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Demo_UC1_ShowGoogleSearchEngineMockup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Demo_UC1_Show Google search engine mockup", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor navigates to Demo site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("URl contains Demo site url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("Demo site title equals to <Google>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goggle page buttons"});
            table1.AddRow(new string[] {
                        "Google Search"});
            table1.AddRow(new string[] {
                        "I\'m Feeling Lucky"});
#line 13
 testRunner.And("Following buttons are present on the Demo site page", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Mockup of External page")]
        [Xunit.TraitAttribute("Description", "Demo_UC2_Show predefined keyword")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Demo_UC2_ShowPredefinedKeyword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Demo_UC2_Show predefined keyword", new string[] {
                        "NeedImplementation"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("Mockup of Google page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When("Actor enters test search text in to search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("Actor clicks Google Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text"});
            table2.AddRow(new string[] {
                        "Sitecore Habitat - Flexibility, Simplicity, Extensibility‎"});
#line 24
 testRunner.Then("Search results contains following sitelink", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Mockup of External page")]
        [Xunit.TraitAttribute("Description", "Demo_UC3_Adwords link on the Google search results mockup")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Demo_UC3_AdwordsLinkOnTheGoogleSearchResultsMockup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Demo_UC3_Adwords link on the Google search results mockup", new string[] {
                        "NeedImplementation"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("Mockup of Google page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.When("Actor enters new test search text in to search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.And("Actor clicks Google Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text"});
            table3.AddRow(new string[] {
                        "Sitecore Habitat - Flexibility, Simplicity, Extensibility‎"});
#line 36
 testRunner.Then("Search results contains following sitelink", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text"});
            table4.AddRow(new string[] {
                        "?sc_camp={0BFFAF94-F523-452A-9F2A-1FA3292D4647}"});
#line 39
 testRunner.And("link with following parametr is present on the page", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Mockup of External page")]
        [Xunit.TraitAttribute("Description", "Demo_UC4_Campaign is triggered on the website")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Demo_UC4_CampaignIsTriggeredOnTheWebsite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Demo_UC4_Campaign is triggered on the website", new string[] {
                        "NeedImplementation"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text"});
            table5.AddRow(new string[] {
                        "?sc_camp={0BFFAF94-F523-452A-9F2A-1FA3292D4647}"});
#line 46
 testRunner.Given("link with following parametr is clicked", ((string)(null)), table5, "Given ");
#line 49
 testRunner.When("Actor clicks info icon in the bottom right corner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Section Name"});
            table6.AddRow(new string[] {
                        "Contact"});
            table6.AddRow(new string[] {
                        "This visist"});
#line 50
 testRunner.Then("flyout with following sections is opened", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text"});
            table7.AddRow(new string[] {
                        "Facebook Content Messages"});
#line 54
 testRunner.And("Camapign drop-down  contains following text", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                MockupOfExternalPageFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                MockupOfExternalPageFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
