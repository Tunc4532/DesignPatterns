using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CoustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 250000)
            {
                CoustemerProcess coustemerProcess = new CoustemerProcess();
                coustemerProcess.Amount = req.Amount.ToString();
                coustemerProcess.Name = req.Name;
                coustemerProcess.EmployeeName = "Şube Müdürü - Ayhan Güllü";
                coustemerProcess.Description = "Para Çekme İşlemi Tamamlandı Müşteriye Talep Ettiği Tutar Ödendi";
                context.coustemerProcesses.Add(coustemerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CoustemerProcess coustemerProcess = new CoustemerProcess();
                coustemerProcess.Amount = req.Amount.ToString();
                coustemerProcess.Name = req.Name;
                coustemerProcess.EmployeeName = "Şube Müdürü - Ayhan Güllü";
                coustemerProcess.Description = "Para Çekme Tutarı Şube Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Bölge Müdürüne Yönlendirildi";
                context.coustemerProcesses.Add(coustemerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
