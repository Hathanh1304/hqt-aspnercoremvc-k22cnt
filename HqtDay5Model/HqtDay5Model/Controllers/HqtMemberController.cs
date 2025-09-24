using HqtDay05Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using HqtDay05Model.Models;

namespace HqtDay05Model.Controllers
{
    public class HqtMemberController : Controller
    {
        static List<HqtMember> members = new List<HqtMember>()
        {
            new HqtMember { MemberId = Guid.NewGuid().ToString(), UserName = "Hqthanh", FullName = "Ha Quoc Thanh", Password = "A123@12", Email = "haquocthanhnb@gmail.com" },
            new HqtMember { MemberId = Guid.NewGuid().ToString(), UserName = "tvanh",   FullName = "Trần Văn Anh",   Password = "B123@34", Email = "anhtran@gmail.com" },
            new HqtMember { MemberId = Guid.NewGuid().ToString(), UserName = "nthao",   FullName = "Nguyễn Thị Thảo", Password = "C123@56", Email = "thaonguyen@gmail.com" },
            new HqtMember { MemberId = Guid.NewGuid().ToString(), UserName = "pvnam",   FullName = "Phạm Văn Nam",   Password = "D123@78", Email = "nampham@gmail.com" },
            new HqtMember { MemberId = Guid.NewGuid().ToString(), UserName = "ltmai",   FullName = "Lê Thị Mai",     Password = "E123@90", Email = "maile@gmail.com" }
        };
        public IActionResult Index()
        {
            // scaffolding

            return View(members);
        }
        // Get HqtCreate
        public IActionResult HqtCreate()
        {
            return View();
        }

        // POST HqtCreate
        [HttpPost]
        public IActionResult HqtCreate(HqtMember model)
        {
            var member = new HqtMember();
            member.MemberId = Guid.NewGuid().ToString();
            member.FullName = model.FullName;
            member.UserName = model.UserName;
            member.Password = model.Password;
            member.Email = model.Email;

            members.Add(member);

            return RedirectToAction("Index");
        }

        // Get HqtEdit
        [HttpGet]
        public IActionResult HqtEdit(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult HqtEdit(string id, HqtMember model)
        {
            members.Where(x => x.MemberId == id).FirstOrDefault().FullName = model.FullName;
            members.Where(x => x.MemberId == id).FirstOrDefault().UserName = model.UserName;
            members.Where(x => x.MemberId == id).FirstOrDefault().Password = model.Password;
            members.Where(x => x.MemberId == id).FirstOrDefault().Email = model.Email;

            return RedirectToAction("Index");
        }

        // Details
        [HttpGet]
        public IActionResult HqtDetails(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // HqtDelete
        [HttpGet]
        public IActionResult HqtDelete(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult HqtDelete(string id, HqtMember model)
        {
            // Tìm thành viên theo MemberId
            var member = members.FirstOrDefault(m => m.MemberId == id);
            if (member != null)
            {
                members.Remove(member); // Xóa khỏi danh sách
            }
            return RedirectToAction("Index");
        }
        public IActionResult HqtGetMember()
        {
            var HqtMember = new HqtMember();
            HqtMember.MemberId = Guid.NewGuid().ToString();
            HqtMember.UserName = "Hqthung";
            HqtMember.FullName = "Trịnh Văn Chung";
            HqtMember.Password = "A123@12";
            HqtMember.Email = "chungtrinhj@gmail.com";

            ViewBag.HqtMember = HqtMember;

            return View();
        }

        public IActionResult HqtGetMembers()
        {
            return View(members);
        }
    }
}