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
namespace Fernweh.BlazorClient.UITests._Features.ThePublicLibrary.Search
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "Search")]
    [Xunit.TraitAttribute("Category", "BasicSearch")]
    [Xunit.TraitAttribute("Category", "Regression")]
    public partial class CanSearchForBooksByISBNAuthorTitleFeature : object, Xunit.IClassFixture<CanSearchForBooksByISBNAuthorTitleFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Search",
                "BasicSearch",
                "Regression"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Search.BasicSearch.Feature"
#line hidden
        
        public CanSearchForBooksByISBNAuthorTitleFeature(CanSearchForBooksByISBNAuthorTitleFeature.FixtureData fixtureData, Fernweh_BlazorClient_UITests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "_Features/ThePublicLibrary/Search", "Can search for books by ISBN, Author, Title", "    As a guest user\r\n    I want to be able to search for books by ISBN, Author, T" +
                    "itle\r\n    So that I can find the book I want", ProgrammingLanguage.CSharp, featureTags);
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
#line 8
    #line hidden
#line 9
        testRunner.Given("we navigate to the search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Search for books using various patterns")]
        [Xunit.TraitAttribute("FeatureTitle", "Can search for books by ISBN, Author, Title")]
        [Xunit.TraitAttribute("Description", "Search for books using various patterns")]
        [Xunit.InlineDataAttribute("0-5170-9394-4", "", "", new string[0])]
        [Xunit.InlineDataAttribute("", "Franky", "", new string[0])]
        [Xunit.InlineDataAttribute("", "", "Book of", new string[0])]
        [Xunit.InlineDataAttribute("", "Franky", "Book of", new string[0])]
        public void SearchForBooksUsingVariousPatterns(string isbnValue, string authorValue, string titleValue, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("isbn value", isbnValue);
            argumentsOfScenario.Add("author value", authorValue);
            argumentsOfScenario.Add("title value", titleValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for books using various patterns", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
    this.FeatureBackground();
#line hidden
#line 12
        testRunner.Given(string.Format("we search for \"{0}\", \"{1}\", \"{2}\"", isbnValue, authorValue, titleValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
        testRunner.And(string.Format("the search values are \"{0}\", \"{1}\", \"{2}\"", isbnValue, authorValue, titleValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
        testRunner.When("we submit the search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
        testRunner.Then("we are on the search result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                CanSearchForBooksByISBNAuthorTitleFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CanSearchForBooksByISBNAuthorTitleFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
