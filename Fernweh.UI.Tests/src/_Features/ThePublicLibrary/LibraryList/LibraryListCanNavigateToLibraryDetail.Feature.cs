﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Fernweh.UITests._Features.ThePublicLibrary.LibraryList
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "smoke")]
    [Xunit.TraitAttribute("Category", "thepubliclibrary")]
    [Xunit.TraitAttribute("Category", "library")]
    [Xunit.TraitAttribute("Category", "librarylist")]
    [Xunit.TraitAttribute("Category", "librarylistnavigate")]
    public partial class LibraryListCanNavigateToLibraryDetailFeature : object, Xunit.IClassFixture<LibraryListCanNavigateToLibraryDetailFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "smoke",
                "thepubliclibrary",
                "library",
                "librarylist",
                "librarylistnavigate"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "LibraryListCanNavigateToLibraryDetail.Feature"
#line hidden
        
        public LibraryListCanNavigateToLibraryDetailFeature(LibraryListCanNavigateToLibraryDetailFeature.FixtureData fixtureData, Fernweh_UITests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "_Features/ThePublicLibrary/LibraryList", "Library List Can Navigate To Library Detail", "    As a guest user\r\n    I want to be able to see a list of libraries\r\n    and se" +
                    "lect one of them to navigate to the library detail page", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
    #line hidden
#line 8
        testRunner.Given("I navigate to the library list page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="I see a library in the list of libraries")]
        [Xunit.TraitAttribute("FeatureTitle", "Library List Can Navigate To Library Detail")]
        [Xunit.TraitAttribute("Description", "I see a library in the list of libraries")]
        [Xunit.InlineDataAttribute("First Street Library", new string[0])]
        [Xunit.InlineDataAttribute("Second Street Library", new string[0])]
        public void ISeeALibraryInTheListOfLibraries(string libraryName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("library name", libraryName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I see a library in the list of libraries", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    this.FeatureBackground();
#line hidden
#line 11
        testRunner.When(string.Format("I select the library by name \"{0}\"", libraryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
        testRunner.Then("I am on the library detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LibraryListCanNavigateToLibraryDetailFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LibraryListCanNavigateToLibraryDetailFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion