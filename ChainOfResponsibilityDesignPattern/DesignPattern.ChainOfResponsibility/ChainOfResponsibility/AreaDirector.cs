using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CoustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CoustemerProcess coustemerProcess = new CoustemerProcess();
                coustemerProcess.Amount = req.Amount.ToString();
                coustemerProcess.Name = req.Name;
                coustemerProcess.EmployeeName = "Bölge Direktörü - Ayşe Güllü";
                coustemerProcess.Description = "Para Çekme İşlemi Tamamlandı Müşteriye Talep Ettiği Tutar Ödendi";
                context.coustemerProcesses.Add(coustemerProcess);
                context.SaveChanges();
            }
            else
            {
                CoustemerProcess coustemerProcess = new CoustemerProcess();
                coustemerProcess.Amount = req.Amount.ToString();
                coustemerProcess.Name = req.Name;
                coustemerProcess.EmployeeName = "Bölge Direktörü - Ayşe Güllü";
                coustemerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Çekebileceği Maksimum Tuter 400.000₺ Olup Daha Fazlası İçin Birden Fazla Gün Şubeye Gelmesi Gerkmektedir...";
                context.coustemerProcesses.Add(coustemerProcess);
                context.SaveChanges();
            }
        }
    }
}
