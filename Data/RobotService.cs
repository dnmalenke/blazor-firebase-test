using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_Firebase_Test.Models;
using Microsoft.JSInterop;

namespace Blazor_Firebase_Test.Data
{
    public class RobotService
    {
        private readonly IJSRuntime _jSRuntime;

        public RobotService(IJSRuntime jsRuntime)
        {
            _jSRuntime = jsRuntime;
        }

        public async Task AddRobot(Robot robot)
        {
            await _jSRuntime.InvokeVoidAsync("firestoreFunctions.addRobot", robot);
        }

        public async Task DeleteRobot(Robot robot)
        {
            await _jSRuntime.InvokeVoidAsync("firestoreFunctions.deleteRobot", robot);
        }

        public async Task<List<Robot>> GetRobots()
        {
            return await _jSRuntime.InvokeAsync<List<Robot>>("firestoreFunctions.getRobots");
        }
    }
}
