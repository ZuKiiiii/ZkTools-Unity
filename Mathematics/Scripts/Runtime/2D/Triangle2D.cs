using System;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.CoordinateSystems;
using ZkTools.Mathematics.Extensions;
using Vector2X = ZkTools.Mathematics.Extensions.Vector2X;

namespace ZkTools.Mathematics.Geometry2D
{
	[Serializable]
	public class Triangle2D : MonoBehaviour
	{
		#region ==============================[Variables]==============================

			public Vector2 a;

			public Vector2 b;

			public Vector2 c;

		#endregion

		#region ==============================[Properties]==============================

			public Segment2D AB => new Segment2D(a, b);

			public Segment2D AC => new Segment2D(a, c);

			public Vector2 AdirB => AtoB.normalized;

			public Vector2 AdirC => AtoC.normalized;

			public Radian AngleA
			{
				get
				{
					float aSqr = Vector2X.FromTo(b, c).sqrMagnitude;
					float bSqr = Vector2X.FromTo(c, a).sqrMagnitude;
					float cSqr = Vector2X.FromTo(a, b).sqrMagnitude;

					return Trigo.Acos((bSqr + cSqr - aSqr) / (Mathf.Sqrt(bSqr) * Mathf.Sqrt(cSqr)));
				}
			}

			public Radian AngleB
			{
				get
				{
					float aSqr = Vector2X.FromTo(b, c).sqrMagnitude;
					float bSqr = Vector2X.FromTo(c, a).sqrMagnitude;
					float cSqr = Vector2X.FromTo(a, b).sqrMagnitude;

					return Trigo.Acos((aSqr + cSqr - bSqr) / (Mathf.Sqrt(aSqr) * Mathf.Sqrt(cSqr)));
				}
			}

			public Radian AngleC
			{
				get
				{
					float aSqr = Vector2X.FromTo(b, c).sqrMagnitude;
					float bSqr = Vector2X.FromTo(c, a).sqrMagnitude;
					float cSqr = Vector2X.FromTo(a, b).sqrMagnitude;

					return Trigo.Acos((aSqr + bSqr - cSqr) / (Mathf.Sqrt(aSqr) * Mathf.Sqrt(bSqr)));
				}
			}

			public Radian[] Angles => CalcAngles(a, b, c);

			public float Area => CalcArea(a, b, c);

			public Vector2 AtoB => Vector2X.FromTo(a, b);

			public Vector2 AtoC => Vector2X.FromTo(a, c);

			public Segment2D BA => new Segment2D(b, a);

			public Segment2D BC => new Segment2D(b, c);

			public Vector2 BdirA => BtoA.normalized;

			public Vector2 BdirC => BtoC.normalized;

			public Vector2 BtoA => Vector2X.FromTo(b, a);

			public Vector2 BtoC => Vector2X.FromTo(b, c);

			public Vector2 Centroid => (a + b + c) / 3.0f;

			public Circle2D? CircumCircle => null; 

			public Segment2D CA => new Segment2D(c, a);

			public Segment2D CB => new Segment2D(c, b);

			public Vector2 CdirA => CtoA.normalized;

			public Vector2 CdirB => CtoB.normalized;

			public Vector2 CtoA => Vector2X.FromTo(c, a);

			public Vector2 CtoB => Vector2X.FromTo(c, b);

			public float Determinant => Vector2X.Det(Vector2X.FromTo(a,b), Vector2X.FromTo(a,c));

			public Vector2[] DirectionsCW => new Vector2[3] {AdirB, BdirC, CdirA};

			public Vector2[] DirectionsCCW => new Vector2[3] {AdirC, CdirB, BdirC};

			public Line2D LineAB => new Line2D(a, AtoB);

			public Line2D LineAC => new Line2D(a, AtoC);

			public Line2D LineBA => new Line2D(b, BtoA);

			public Line2D LineBC => new Line2D(b, BtoC);

			public Line2D LineCA => new Line2D(c, CtoA);

			public Line2D LineCB => new Line2D(c, CtoB);

			public Line2D[] LinesCW => new Line2D[3] {LineAB, LineBC, LineCA};

			public Line2D[] LinesCCW => new Line2D[3] {LineAC, LineCB, LineBC};

			public Circle2D InCircle => CalcInCircle(a, b, c);

			public Segment2D[] SegmentsCW => new Segment2D[3] {AB, BC, CA};

			public Segment2D[] SegmentsCCW => new Segment2D[3] {AC, CB, BC};

			public float SignedArea => CalcSignedArea(a, b, c);

			public Vector2 this [int p_index]
			{
				get
				{
					switch (p_index)
					{
						case 0 : return a;
						case 1 : return b;
						case 2 : return c;
						default : throw new System.IndexOutOfRangeException("Index of " + p_index + " is not valid ! Range of Triangle2D : [0,2] !");
					}
				}
				set
				{
					switch (p_index)
					{
						case 0 : a = value; break;
						case 1 : b = value; break;
						case 2 : c = value; break;
						default : throw new System.IndexOutOfRangeException("Index of " + p_index + " is not valid ! Range of Triangle2D : [0,2] !");
					}
				}
			}

			public Vector2[] Vertices => new Vector2[3] {a, b, c};

			public Vector2[] VectorsCW => new Vector2[3] {AtoB, BtoC, CtoA};

			public Vector2[] VectorsCCW => new Vector2[3] {AtoC, CtoB, BtoC};

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Triangle2D(Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				a = p_a;
				b = p_b;
				c = p_c;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static Radian[] CalcAngles (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				float aSqr = Vector2X.FromTo(p_b, p_c).sqrMagnitude;
				float bSqr = Vector2X.FromTo(p_c, p_a).sqrMagnitude;
				float cSqr = Vector2X.FromTo(p_a, p_b).sqrMagnitude;
				float twoC = 2.0f * Mathf.Sqrt(cSqr);

				Radian radA = Trigo.Acos((bSqr + cSqr - aSqr) / (MathF.Sqrt(bSqr) * twoC));
				Radian radB = Trigo.Acos((aSqr + cSqr - bSqr) / (MathF.Sqrt(aSqr) * twoC));
				Radian radC = Radian.Half - radA - radB;

				return new Radian[3] {radA, radB, radC};
			}

			public static float CalcArea (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return Math.Abs(CalcSignedArea(p_a, p_b, p_c));
			}

			public static float CalcArea (float p_width, float p_height)
			{
				return (p_width * p_height) * 0.5f;
			}

			public static float CalcArea(Vector2 p_size)
			{
				return CalcArea(p_size.x, p_size.y);
			}

			public static Circle2D CalcInCircle (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				float distAB = Vector2.Distance(p_a, p_b);
				float distBC = Vector2.Distance(p_b, p_c);
				float distCA = Vector2.Distance(p_c, p_a);

				float perimeter = distAB + distBC + distCA;

				Vector2 inCenter = (p_a * distBC + p_b * distCA + p_c * distAB) / perimeter;

				float s = perimeter * 0.5f;
				float radius = MathF.Sqrt((s - distBC) * (s - distCA) * (s - distAB) / s);

				return new Circle2D(inCenter, radius);
			}

			public static float CalcSignedArea (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return Vector2X.Det(p_b - p_a, p_c - p_a) * 0.5f;
			}

		#endregion

		#region ==============================[Static Methods]==============================


		#endregion
	}

	public enum EOrientationDirection
	{
		/** Clockwise */
		CW,
		
		/** Counter Clockwise */
		CCW
	}
}


