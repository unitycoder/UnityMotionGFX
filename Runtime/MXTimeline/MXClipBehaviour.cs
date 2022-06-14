using UnityEngine.Playables;

namespace Voxell.MotionGFX
{
  public class MXClipBehaviour : PlayableBehaviour
  {
    public MXClipGroup clipGroup;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
      float playableTime = (float) playable.GetTime();
      clipGroup.Evaluate(playableTime);
    }
  }
}