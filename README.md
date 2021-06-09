# IES Framework

[![Build and test](https://github.com/iesyazilim/logo/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/iesyazilim/logo/actions/workflows/build-and-test.yml)
[![NuGet](https://img.shields.io/nuget/v/Ies.Logo.Datatype.svg)](https://www.nuget.org/packages/Ies.Logo.Datatype)
[![NuGet Download](https://img.shields.io/nuget/dt/Ies.Logo.Datatype.svg)](https://www.nuget.org/packages/Ies.Logo.Datatype)

## Framework Sağladığı Kolaylıklar
- Güçlü nesne tabanlı yaklaşımı.
- İş kodlarını soyutlayarak katmanlar arası bağımlılığı minumuma düşürmek.
- Logo modülleri standartlaştırarak sürdürülebilir hale getirmek.

## Hızlı Başlangıç
Gerekli referans ve injection tanımlamaları yapıldıktan sonra **LogoManager, LogoCrudManager** sınıflarından kalıtım alınarak geliştirilmeye başlanılabilir.

### Proje modeli örnek LogoManager kalıtımı
```csharp
public class ProjectManager : LogoManager, IProjectService
{
    private readonly ILogoRepository<Project> _projectRepository;
    
    public ProjectManager(
        ILogoConnectionConfiguration configuration, 
        ILogoRepository<Project> projectRepository) 
        : base(configuration)
    {
        _projectRepository = projectRepository;
    }
    
    public void Info()
    {
        //Geçerli firma bilgisini Configuration özelliğinden ulaşılabilir
        //ILogoConnectionConfiguration interface genişletilerek geliştirilen projeye özel tanımlamalar yapılabilir
        string currentFirm = Configuration.FirmNumber;
        string currentPeriod = Configuration.FirmPeriod;
        SqlConnection currentConnection = Configuration.Create();
    }
    
    public async Task CrudJobs()
    {
        Project project = await _projectRepository.GetAsync(1);//Logodan 1 idli projeyi getirir

        int projectReference = await _projectRepository.AddOrUpdateAsync(new Project
        {
            Code = "Proje-1",
            Name = "Örnek proje"
        });//Logoya yeni proje oluşturur

        await _projectRepository.DeleteAsync(1);//Logodan 1 idli projeyi siler
    }
}
```
### Proje modeli örnek LogoCrudManager kalıtımı
```csharp
public class ProjectManager : LogoCrudManager<Project>
{
    public ProjectManager(
        ILogoConnectionConfiguration configuration,
        ILogoRepository<Project> projectRepository)
        : base(configuration, projectRepository)
    {

    }

    //AddOrUpdate, Get, Delete metotları base sınıfta hazır olarak gelmekte
    
    public async Task SomeBusinessJob()
    {
        //Repository özelliği ile basit Crud işlemlerini gerçekleştirebiliriz
        var project = await Repository.GetAsync(1);
    }
}
```

## Framework Katmanları

- Ies.Logo.DataType 
  - Logo modellerinin bulunmuş olduğu katmandır.
  - Var olan sınıflardan kalıtım alınarak özelleştirme yapılabilir.
  - Xml alanlarını fluent api şeklinde eşleştirme yapılarak kod okunabilirliğini artırır.

- Ies.Logo.ServiceAdapter
  - LogoObjectService proxy sınıfını ServiceAdapter tasarım kalıbıyla sarmalamış katmandır.

- Ies.Logo.Repositories
  - GenericRepository tasarım kalıbı uygulanmış base sınıfın bulunduğu katmandır.

- Ies.Logo.Manager
  - Temel logo metotlarının bulunduğu katmandır.
  
