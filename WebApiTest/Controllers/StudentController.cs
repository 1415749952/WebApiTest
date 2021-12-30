using Microsoft.AspNetCore.Mvc;
using webApiDomain.ao;
using webApiDomain.bo;
using webApiDomain.domain;

namespace WebApiTest.Controllers;

[Route("api/student")]
[ApiController]
public class StudentController
{
    /// <summary>
    /// 添加学生
    /// </summary>
    /// <param name="studentAo"></param>
    /// <returns></returns>
    [HttpPost]
    public int addStudent([FromBody] StudentAo studentAo)
    {
        return 1;
    }

    /// <summary>
    /// 删除一个学生
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public int deleteStudent([FromRoute] string id)
    {
        return 1;
    }

    /// <summary>
    /// 修改学生信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="studentAo"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public int updateStudent([FromRoute] string id, [FromBody] StudentAo studentAo)
    {
        return 1;
    }


    /// <summary>
    /// 查询学生
    /// </summary>
    /// <param name="studentQo"></param>
    /// <returns></returns>
    [HttpGet]
    public List<Student> selectStudent([FromQuery] StudentQo studentQo)
    {
        return new List<Student>();
    }

    /// <summary>
    /// 查询一个学生详细信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Student selectStudentDetail([FromRoute] string id)
    {
        return new Student();
    }
}