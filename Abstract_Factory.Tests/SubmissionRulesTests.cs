using Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Tests
{
    public class SubmissionRulesTests
    {
        [Theory]  
        [InlineData(".pdf")]
        public void CheckOnlineSubmission_ForCorrectlyMarksAFile(string fileName)
        {
            ISubmissionCoursework submission = new OnlineUploadDefense();

            var ex = Record.Exception(() => submission.Submit(fileName));
            Assert.Null(ex);
        }

        [Theory]
        [InlineData("https: //github.com/.git")]
        public void CheckGitHubSubmission_ForCorrectlyRepositoryLink(string fileName)
        {
            ISubmissionCoursework submission = new GitHubRepoDefense();

            var ex = Record.Exception(() => submission.Submit(fileName));
            Assert.Null(ex);
        }
    }
}
