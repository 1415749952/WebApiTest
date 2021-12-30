using webApiDomain.domain;

namespace webApiService.service;

public interface StudentService
{
    /// <summary>
    /// 新增学生
    /// </summary>
    /// <returns></returns>
    public int addStudent(Student student);
    
}