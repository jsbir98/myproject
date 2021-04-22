using Matagujri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Matagujri.Controllers
{
    public class person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
    public class MataGujriController : ApiController
    {
        [HttpGet]
        public ApiResponse GetWelcomeMessage()
        {
            return new ApiResponse(HttpStatusCode.OK, "Welcome to Matagujri Api Server", "Welcome to Matagujri Industrial Training Session");
        }
        [HttpDelete]
        public ApiResponse DeleteMessage(int id)
        {
            var user = StudentProvider.GetStudentList().Where(d=>d.StudentId==id).FirstOrDefault();
            return new ApiResponse(HttpStatusCode.OK, "Delete Message successfully performed", string.Format("User {0} successfully deleted!!", user.Name));
        }
        [HttpPut]
        public ApiResponse PutMessage(person person)
        {
            return new ApiResponse(HttpStatusCode.OK, "Put Message successfully performed", string.Format("User {0} {1} successfully updated", person.firstname, person.lastname));
        }
        [HttpPost]
        public ApiResponse PostMessage(person person)
        {
            return new ApiResponse(HttpStatusCode.OK, "Post Message successfully posted", string.Format("Welcome {0} {1} to Matagujri College", person.firstname, person.lastname));
        }
        [HttpPost]
        public ApiResponse AuthenticateUser(User user)
        {
            var userList = new List<User>();
            userList.Add(new User { username = "ankush", password = "123456" });
            userList.Add(new User { username = "ankush1802@outlook.com", password = "123456" });
            userList.Add(new User { username = "mukesh", password = "123456" });
            userList.Add(new User { username = "sarao", password = "123456" });
            if (userList.Where(d => d.username.Equals(user.username) && d.password.Equals(user.password)).Any())
            {
                if (user.username.Equals("ankush"))
                    return new ApiResponse(HttpStatusCode.OK, "User Validated", "/Tables.html");
                else
                    return new ApiResponse(HttpStatusCode.OK, "User Validated", "/Home.html");
            }
            else
                return new ApiResponse(HttpStatusCode.Unauthorized, "User Validated", "/Unauthorized.html");
        }
        [HttpPost]
        public GetStudentResponse GetStudentList([FromBody] FormDataCollection Form)
        {

            try
            {
                var draw = Form.GetValues("draw").FirstOrDefault();
                var start = Form.GetValues("start").FirstOrDefault();
                var length = Form.GetValues("length").FirstOrDefault();
                var sortColumn = Form.GetValues("columns[" + Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                var sortColumnDir = Form.GetValues("order[0][dir]").FirstOrDefault();
                var searchValue = Form.GetValues("search[value]").FirstOrDefault();


                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data    
                var studentData = StudentProvider.GetStudentList().AsQueryable();

                //Sorting    
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                {
                    //studentData.OrderBy(sortColumn + " " + sortColumnDir);
                    if (sortColumnDir.Trim().ToLower() == "asc")
                    {
                        studentData = SortHelper.OrderBy(studentData, sortColumn);
                    }
                    else
                    {
                        studentData = SortHelper.OrderByDescending(studentData, sortColumn);
                    }
                }
                //Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    studentData = studentData.Where(m => m.Name == searchValue);
                }

                //total number of rows count     
                recordsTotal = studentData.Count();
                //Paging     
                var data = studentData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data    
                return new GetStudentResponse { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
