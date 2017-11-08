namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink
{
  using Sitecore.Modules.EmailCampaign.Core;
  using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
  using Sitecore.Sites;

  public class HandleInternalLink : Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink.Hyperlink.HandleInternalLink
  {
    public override void Process(GenerateLinkPipelineArgs args)
    {
      base.Process(args);
      #region Added code
      if (args.MailMessage.InnerItem.TemplateID.ToString() == TemplateIds.RichTextMessage)
      {
        string remove = "://" + SiteContext.GetSite(args.WebsiteConfigurationName).HostName + "/";
        args.Url = args.Url.Replace(remove, "");
      }
      #endregion
    }
  }
}