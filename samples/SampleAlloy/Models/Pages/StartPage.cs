using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using SampleAlloy.Models.Blocks;

namespace SampleAlloy.Models.Pages
{
    /// <summary>
    /// Used for the site's start page and also acts as a container for site settings
    /// </summary>
    [ContentType(
        GUID = "19671657-B684-4D95-A61F-8DD4FE60D559",
        GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage), typeof(ContentFolder) }, // Pages we can create under the start page...
        ExcludeOn = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage) })] // ...and underneath those we can't create additional start pages
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference MainImage { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference EmptyImage { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "XS (< 576)", Order = 200)]
        public virtual ContentReference XSImage { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "Small (>= 576)", Order = 201)]
        public virtual ContentReference SMImage { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "Medium (>= 768)", Order = 202)]
        public virtual ContentReference MDImage { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "Medium (>= 992)", Order = 203)]
        public virtual ContentReference LGImage { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "Extra Large(>= 1200)", Order = 204)]
        public virtual ContentReference XLImage { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 300)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 350)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 400)]
        public virtual LinkItemCollection NewsPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 450)]
        public virtual LinkItemCollection CustomerZonePageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference GlobalNewsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }

    }
}
