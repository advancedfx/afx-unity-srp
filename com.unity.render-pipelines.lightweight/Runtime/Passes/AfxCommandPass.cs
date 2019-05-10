using System;

namespace UnityEngine.Rendering.LWRP
{
    internal class AfxCommandPass : ScriptableRenderPass
    {
		CommandBuffer afxCommand;

        public AfxCommandPass(RenderPassEvent evt)
        {
			renderPassEvent = evt;
        }

        public void Setup(CommandBuffer afxCommand)
        {
			this.afxCommand = afxCommand;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            context.ExecuteCommandBuffer(afxCommand);
        }
    }
}
