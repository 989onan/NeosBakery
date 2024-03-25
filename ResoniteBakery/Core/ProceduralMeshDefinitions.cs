using Elements.Core;
using FrooxEngine;
using System.Linq;
using System.Text;

namespace ResoniteBakery.Core
{
    static class ProceduralMeshDefinitions
    {
        public static int GetMeshHashCode(ProceduralMesh proceduralMesh)
        {
            try
            {
                return MeshHashCode((dynamic)proceduralMesh);
            }
            catch
            {
                return -1;
            }
        }
        static int MeshHashCode(BoxMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Size.Value.x);
            stringBuilder.Append(mesh.Size.Value.y);
            stringBuilder.Append(mesh.Size.Value.z);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.UVScale.Value.z);
            stringBuilder.Append(mesh.ScaleUVWithSize.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(CapsuleMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Radius.Value);
            stringBuilder.Append(mesh.Height.Value);
            stringBuilder.Append(mesh.Segments.Value);
            stringBuilder.Append(mesh.Rings.Value);
            stringBuilder.Append(mesh.Shading.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.DualSided.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(ConeMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Height.Value);
            stringBuilder.Append(mesh.RadiusBase.Value);
            stringBuilder.Append(mesh.RadiusTop.Value);
            stringBuilder.Append(mesh.Sides.Value);
            stringBuilder.Append(mesh.Caps.Value);
            stringBuilder.Append(mesh.FlatShading.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(CylinderMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Height.Value);
            stringBuilder.Append(mesh.Radius.Value);
            stringBuilder.Append(mesh.Sides.Value);
            stringBuilder.Append(mesh.Caps.Value);
            stringBuilder.Append(mesh.FlatShading.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(GridMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Points.Value.x);
            stringBuilder.Append(mesh.Points.Value.y);
            stringBuilder.Append(mesh.Size.Value.x);
            stringBuilder.Append(mesh.Size.Value.y);
            stringBuilder.Append(mesh.FlatShading.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(QuadMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Rotation.Value.x);
            stringBuilder.Append(mesh.Rotation.Value.y);
            stringBuilder.Append(mesh.Rotation.Value.z);
            stringBuilder.Append(mesh.Rotation.Value.w);
            stringBuilder.Append(mesh.Size.Value.x);
            stringBuilder.Append(mesh.Size.Value.y);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.ScaleUVWithSize.Value);
            stringBuilder.Append(mesh.UVOffset.Value.x);
            stringBuilder.Append(mesh.UVOffset.Value.y);
            stringBuilder.Append(mesh.DualSided.Value);
            stringBuilder.Append(mesh.UseVertexColors.Value);
            stringBuilder.Append(mesh.UpperLeftColor.Value);
            stringBuilder.Append(mesh.LowerLeftColor.Value);
            stringBuilder.Append(mesh.LowerRightColor.Value);
            stringBuilder.Append(mesh.UpperRightColor.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(SphereMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Radius.Value);
            stringBuilder.Append(mesh.Segments.Value);
            stringBuilder.Append(mesh.Rings.Value);
            stringBuilder.Append(mesh.Shading.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.DualSided.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(TorusMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.MinorSegments.Value);
            stringBuilder.Append(mesh.MajorSegments.Value);
            stringBuilder.Append(mesh.MinorRadius.Value);
            stringBuilder.Append(mesh.MajorRadius.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(BevelRingMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Arc.Value);
            stringBuilder.Append(mesh.ArcOffset.Value);
            stringBuilder.Append(mesh.Radius.Value);
            stringBuilder.Append(mesh.Width.Value);
            stringBuilder.Append(mesh.Thickness.Value);
            stringBuilder.Append(mesh.Tilt.Value);
            stringBuilder.Append(mesh.Segments.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(TubeSpiralMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Steps.Value);
            stringBuilder.Append(mesh.StartSpiralRadius.Value);
            stringBuilder.Append(mesh.EndSpiralRadius.Value);
            stringBuilder.Append(mesh.CoilPhase.Value);
            stringBuilder.Append(mesh.CoilCount.Value);
            stringBuilder.Append(mesh.StartPoint.Value);
            stringBuilder.Append(mesh.EndPoint.Value);
            stringBuilder.Append(mesh.Ends.Value);
            stringBuilder.Append(mesh.Shading.Value);
            stringBuilder.Append(mesh.ScaleCoilCountByLength.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(CircleMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Rotation.Value.x);
            stringBuilder.Append(mesh.Rotation.Value.y);
            stringBuilder.Append(mesh.Rotation.Value.z);
            stringBuilder.Append(mesh.Rotation.Value.w);
            stringBuilder.Append(mesh.Segments.Value);
            stringBuilder.Append(mesh.Radius.Value);
            stringBuilder.Append(mesh.Arc.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.ScaleUVWithSize.Value);
            stringBuilder.Append(mesh.TriangleFan.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(BevelBoxMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Size.Value.x);
            stringBuilder.Append(mesh.Size.Value.y);
            stringBuilder.Append(mesh.Size.Value.z);
            stringBuilder.Append(mesh.Bevel.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.UVScale.Value.z);
            stringBuilder.Append(mesh.ScaleUVWithSize.Value);

            return stringBuilder.ToString().GetHashCode();
        }
        static int MeshHashCode(CurvedPlaneMesh mesh)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mesh.Size.Value.x);
            stringBuilder.Append(mesh.Size.Value.y);
            stringBuilder.Append(mesh.Curvature.Value);
            stringBuilder.Append(mesh.TiltAngle.Value);
            stringBuilder.Append(mesh.AspectRatioCompensation.Value);
            stringBuilder.Append(mesh.UVScale.Value.x);
            stringBuilder.Append(mesh.UVScale.Value.y);
            stringBuilder.Append(mesh.UVOffset.Value.x);
            stringBuilder.Append(mesh.UVOffset.Value.y);
            stringBuilder.Append(mesh.Segments.Value);
            stringBuilder.Append(mesh.FlatShading.Value);

            return stringBuilder.ToString().GetHashCode();
        }
    }
}
