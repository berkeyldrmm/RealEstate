using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.Models;
using System.Collections.Generic;

namespace RealEstate.Controllers
{
    public class TaskController : Controller
    {
        private readonly UserManager<User> _userManager;
        public TaskController(UserManager<User> userManager)
        {
            _userManager = userManager;
            
        }
        public async Task<string> getTasks()
        {
            var user = await _userManager.GetUserAsync(User);
            var tasks = user.Tasks;

            return tasks;
        }

        [HttpPost]
        public async Task<IActionResult> addTask(string taskText)
        {
            var user = await _userManager.GetUserAsync(User);
            TaskModel task = new TaskModel()
            {
                Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                TaskText = taskText,
                Status = true
            };
            List<TaskModel> tasks = JsonConvert.DeserializeObject<List<TaskModel>>(user.Tasks);
            tasks.Add(task);
            string tasksJson = JsonConvert.SerializeObject(tasks);
            user.Tasks = tasksJson;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            throw new Exception("Bir hata oluştu.");

        }
        [HttpDelete]
        public async Task<IActionResult> deleteTask(string taskId)
        {
            var user = await _userManager.GetUserAsync(User);
            List<TaskModel> tasks = JsonConvert.DeserializeObject<List<TaskModel>>(user.Tasks);
            var task = tasks.FirstOrDefault(t => t.Id == taskId);
            var result = tasks.Remove(task);
            if (result)
            {
                user.Tasks = JsonConvert.SerializeObject(tasks);
                var result1 = await _userManager.UpdateAsync(user);
                if (result1.Succeeded)
                {
                    return Ok();
                }
            }
            throw new Exception("Bir hata oluştu.");
        }

        public async Task<IActionResult> signAsDoneTask(bool checkedInput, string taskId)
        {
            var user = await _userManager.GetUserAsync(User);
            List<TaskModel> tasks = JsonConvert.DeserializeObject<List<TaskModel>>(user.Tasks);
            var task = tasks.FirstOrDefault(t => t.Id == taskId);
            task.Status = checkedInput;
            user.Tasks = JsonConvert.SerializeObject(tasks);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            throw new Exception("Bir hata oluştu.");
        }
    }
}
