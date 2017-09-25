using System.Web.Mvc;

namespace EpiCustomRendering.Business.Rendering.Conventions
{
    public interface ITagBuilderConvention
    {
        void Apply(ContentAreaRenderingContext context, TagBuilder tagBuilder);
    }
}