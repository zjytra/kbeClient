// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2x4
    {
        [Test]
        public void float2x4_operator_equal_wide_wide()
        {
            float2x4 a0 = float2x4(492.1576f, -495.206329f, 227.457642f, -147.374054f, -222.682f, 64.09375f, -23.8904114f, -16.8197327f);
            float2x4 b0 = float2x4(192.568787f, -235.611023f, -254.043121f, -412.624725f, 471.9048f, -6.47277832f, -339.102356f, 488.187561f);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x4 a1 = float2x4(163.232117f, -165.271f, 470.8777f, -423.942566f, 109.6344f, 462.6903f, -335.38147f, 357.2345f);
            float2x4 b1 = float2x4(-379.5966f, -308.417f, -82.333374f, -102.921082f, 226.515747f, -356.9013f, -362.912781f, -427.898438f);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x4 a2 = float2x4(1.54559326f, -347.388245f, -114.472168f, 435.848633f, 194.2381f, 138.765564f, -467.349152f, 370.43335f);
            float2x4 b2 = float2x4(466.650146f, -102.799042f, -43.355957f, 85.0456543f, -91.1270447f, 422.192078f, -477.4313f, 1.87701416f);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x4 a3 = float2x4(476.708252f, 320.552673f, -498.59198f, 92.41693f, 104.511353f, 166.754578f, -204.733429f, 434.756775f);
            float2x4 b3 = float2x4(312.580078f, 254.599365f, 352.72583f, 62.4909668f, 119.714783f, -511.058075f, -302.472717f, -371.769226f);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x4_operator_equal_wide_scalar()
        {
            float2x4 a0 = float2x4(-303.230072f, 451.5263f, -253.655884f, -105.203644f, -500.6911f, -426.192474f, 159.8761f, -59.55838f);
            float b0 = (123.544556f);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x4 a1 = float2x4(-57.4773865f, 406.513733f, 370.886f, -172.035309f, 455.400024f, -11.3389893f, 363.938232f, -27.1505737f);
            float b1 = (-182.049744f);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x4 a2 = float2x4(-325.976074f, 180.196838f, -374.128326f, -439.358948f, -126.546082f, -197.26178f, -227.159332f, -479.8992f);
            float b2 = (-290.359039f);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x4 a3 = float2x4(-439.777679f, -224.517059f, -422.833221f, -450.196259f, -20.10672f, 297.38f, 185.966553f, -102.975983f);
            float b3 = (-495.237335f);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x4_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float2x4 b0 = float2x4(19.95221f, -185.791992f, 407.8136f, -87.2767f, -206.274689f, 160.503113f, -274.7708f, -2.63153076f);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (448.354553f);
            float2x4 b1 = float2x4(-410.035248f, 247.329041f, 355.539124f, -298.0667f, 414.1015f, -481.3026f, 196.55072f, 34.6010132f);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (113.7616f);
            float2x4 b2 = float2x4(-386.453369f, -124.49176f, 243.886658f, -492.6182f, 145.424438f, 421.55072f, -95.40997f, 336.809265f);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (209.5838f);
            float2x4 b3 = float2x4(487.4414f, 161.806519f, 149.842468f, 225.724f, -71.21881f, 85.78027f, 192.547241f, -49.88748f);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x4_operator_not_equal_wide_wide()
        {
            float2x4 a0 = float2x4(430.842529f, 104.69f, 225.802429f, -310.5702f, -418.619446f, 304.128174f, -509.3268f, -160.538086f);
            float2x4 b0 = float2x4(210.024719f, -55.20334f, -269.925354f, -234.546722f, 25.91742f, -63.72699f, -484.5537f, -425.3336f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x4 a1 = float2x4(-203.301971f, -505.763245f, 162.17218f, 1.156189f, 65.66205f, 102.787781f, 172.930054f, 26.6210327f);
            float2x4 b1 = float2x4(-53.2743835f, 328.1944f, 15.9631348f, 461.7141f, -113.363037f, -240.072968f, 495.119141f, 203.55835f);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x4 a2 = float2x4(235.125977f, 128.541992f, -354.996979f, 334.3595f, -495.832f, 468.307373f, 458.370972f, 299.937317f);
            float2x4 b2 = float2x4(340.493469f, -241.9072f, 459.569824f, 213.07373f, -384.782837f, -255.072327f, 477.663452f, -248.036621f);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x4 a3 = float2x4(43.1271973f, -354.7135f, -145.2872f, 390.80188f, -303.13147f, 391.134583f, 139.286865f, 104.523193f);
            float2x4 b3 = float2x4(-407.923462f, -199.788879f, 151.843262f, -97.1206055f, 154.975891f, -172.834534f, 441.5028f, -401.738617f);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x4_operator_not_equal_wide_scalar()
        {
            float2x4 a0 = float2x4(-16.9145813f, 168.8341f, -462.713531f, 130.307739f, 214.501587f, -440.263275f, -197.12796f, -169.099854f);
            float b0 = (-145.372772f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x4 a1 = float2x4(-386.611176f, -270.26886f, -403.9637f, -269.805725f, 299.654236f, -71.7509155f, -432.755737f, -457.363129f);
            float b1 = (-281.021f);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x4 a2 = float2x4(-13.5195923f, 185.04248f, -482.5307f, 116.395142f, 511.735f, 230.5075f, 100.27478f, 129.682434f);
            float b2 = (273.873047f);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x4 a3 = float2x4(321.178772f, 140.3352f, 369.212341f, 453.811218f, -333.66626f, -373.937744f, 150.204285f, -442.164764f);
            float b3 = (-220.639f);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x4_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float2x4 b0 = float2x4(-57.1969f, -382.432526f, 97.82037f, -161.463654f, -458.39563f, -499.617859f, 327.92218f, 367.571228f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (59.786377f);
            float2x4 b1 = float2x4(-209.580688f, -62.5804443f, -479.974976f, -49.4945068f, -114.685211f, 109.93927f, -176.284821f, -347.4853f);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (85.5409546f);
            float2x4 b2 = float2x4(-356.659546f, -104.243561f, -133.5492f, 243.539734f, 13.1412964f, -379.985962f, -41.28122f, 87.91168f);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-339.077271f);
            float2x4 b3 = float2x4(-371.820343f, 333.1443f, 294.811951f, -187.14566f, 220.192261f, -228.182068f, -499.723724f, 97.40588f);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x4_operator_less_wide_wide()
        {
            float2x4 a0 = float2x4(196.84259f, 336.4098f, 251.963745f, 257.655945f, 430.0459f, -62.4196472f, 8.839233f, -333.8167f);
            float2x4 b0 = float2x4(-465.345032f, -256.1524f, -314.814026f, 364.5667f, 100.21051f, 182.560974f, 3.11700439f, -259.430481f);
            bool2x4 r0 = bool2x4(false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x4 a1 = float2x4(164.678833f, -350.9449f, 3.84143066f, 125.409729f, -111.129944f, 70.00549f, 448.1983f, -419.987122f);
            float2x4 b1 = float2x4(-437.3349f, -456.043732f, -394.255981f, 401.9137f, 313.439148f, 121.286682f, -28.0122986f, -282.965881f);
            bool2x4 r1 = bool2x4(false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x4 a2 = float2x4(-258.301666f, -34.8322144f, -69.8594055f, 67.76721f, -139.777283f, 385.434631f, 133.7074f, 506.188354f);
            float2x4 b2 = float2x4(330.0644f, 124.099365f, -183.6903f, 373.0608f, 109.750916f, -203.57135f, 45.64868f, -360.952271f);
            bool2x4 r2 = bool2x4(true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x4 a3 = float2x4(34.44287f, 412.1137f, -84.8097839f, 444.785339f, -78.75473f, 366.977539f, 127.180481f, 428.368469f);
            float2x4 b3 = float2x4(211.913086f, -313.286377f, -259.661072f, 79.09851f, 446.4961f, 450.524536f, -375.630768f, -53.9418335f);
            bool2x4 r3 = bool2x4(true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x4_operator_less_wide_scalar()
        {
            float2x4 a0 = float2x4(-132.057312f, -192.465f, -66.8345947f, -379.017517f, -360.2824f, 20.9278564f, -158.240753f, 437.3459f);
            float b0 = (-156.010223f);
            bool2x4 r0 = bool2x4(false, true, false, true, true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x4 a1 = float2x4(-20.4526062f, 307.4842f, 274.015259f, 373.549683f, 398.523682f, 105.030151f, -58.0108948f, 109.670105f);
            float b1 = (225.2915f);
            bool2x4 r1 = bool2x4(true, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x4 a2 = float2x4(-108.85318f, 140.426086f, -500.0883f, 172.103333f, -197.500732f, -7.271515f, -432.9905f, 62.1583252f);
            float b2 = (-44.9712524f);
            bool2x4 r2 = bool2x4(true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x4 a3 = float2x4(-72.25473f, -500.255737f, 149.11499f, 119.880615f, 202.63916f, 274.950684f, 66.41205f, 274.999451f);
            float b3 = (-377.852325f);
            bool2x4 r3 = bool2x4(false, true, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x4_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float2x4 b0 = float2x4(385.094849f, -123.933472f, 86.37659f, 133.4422f, 161.457947f, 229.754272f, 222.5716f, 315.5312f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-447.203522f);
            float2x4 b1 = float2x4(271.833862f, -393.605316f, 317.486877f, -164.6051f, -282.876038f, 296.979553f, -254.401154f, 365.6156f);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-441.984253f);
            float2x4 b2 = float2x4(-131.42865f, 442.628967f, -29.7928467f, -138.37381f, 9.21698f, -226.73056f, 171.029419f, 376.625244f);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-462.5887f);
            float2x4 b3 = float2x4(-142.36731f, -456.253784f, 66.61023f, 169.378784f, 327.4444f, 64.08795f, -153.5039f, 199.380127f);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_wide_wide()
        {
            float2x4 a0 = float2x4(483.5014f, 310.8156f, 106.966187f, 295.7353f, 116.957581f, -478.299774f, -14.8974f, -33.8174438f);
            float2x4 b0 = float2x4(-471.398f, -371.9853f, 36.9006958f, -316.7636f, 19.6830444f, 207.309143f, 362.7975f, 324.95343f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x4 a1 = float2x4(-24.74054f, 319.782654f, -120.158569f, -289.008575f, 455.85144f, 144.706909f, 63.9320068f, -285.683044f);
            float2x4 b1 = float2x4(340.948059f, 25.9860229f, -114.211121f, 240.803467f, 273.422424f, 325.515747f, 27.3410645f, 64.47955f);
            bool2x4 r1 = bool2x4(false, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x4 a2 = float2x4(-502.090729f, -337.194458f, 474.317322f, -507.1451f, -133.565582f, -443.109131f, -464.34137f, -68.36154f);
            float2x4 b2 = float2x4(200.948364f, 100.122681f, -79.00711f, -315.137939f, -122.985443f, -163.7792f, -492.566f, -90.79727f);
            bool2x4 r2 = bool2x4(false, false, true, false, false, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x4 a3 = float2x4(-185.993011f, -157.8039f, -74.12424f, -94.47116f, 329.610535f, -315.836731f, 404.1938f, 131.304382f);
            float2x4 b3 = float2x4(-284.901245f, -23.6536865f, 174.93f, 85.7125244f, -441.987823f, 345.543762f, 482.219482f, -422.383484f);
            bool2x4 r3 = bool2x4(true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_wide_scalar()
        {
            float2x4 a0 = float2x4(64.31793f, -397.703461f, 431.8769f, 85.703f, 246.263062f, 197.491577f, 286.199463f, 280.813354f);
            float b0 = (305.859924f);
            bool2x4 r0 = bool2x4(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x4 a1 = float2x4(-405.7846f, -241.807281f, 333.5782f, 370.279175f, -413.7014f, -356.592346f, -353.0313f, 396.645325f);
            float b1 = (171.565369f);
            bool2x4 r1 = bool2x4(false, false, true, true, false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x4 a2 = float2x4(467.222046f, 502.915039f, 315.4676f, -259.2897f, 281.230652f, 428.792175f, 245.153076f, -279.1754f);
            float b2 = (-240.013428f);
            bool2x4 r2 = bool2x4(true, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x4 a3 = float2x4(-453.8631f, -425.652924f, 99.13287f, 355.060547f, -456.439423f, 154.489014f, 405.529724f, -157.7338f);
            float b3 = (-124.771545f);
            bool2x4 r3 = bool2x4(false, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float2x4 b0 = float2x4(358.099976f, -72.596405f, -232.163788f, -60.7067261f, 75.15662f, 150.883484f, 339.539185f, -498.196045f);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (459.7461f);
            float2x4 b1 = float2x4(-227.968719f, 335.862122f, 76.17883f, 296.859924f, 177.48999f, -281.2012f, 244.722839f, 137.328552f);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-385.338257f);
            float2x4 b2 = float2x4(443.163452f, -353.562561f, 26.04065f, -331.793945f, -43.6919556f, 20.9494019f, -211.17984f, 227.421692f);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-84.7797852f);
            float2x4 b3 = float2x4(-375.1355f, -205.178131f, -197.04715f, -219.634033f, -210.015625f, -266.7737f, 144.7785f, -471.7112f);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x4_operator_less_equal_wide_wide()
        {
            float2x4 a0 = float2x4(-438.523132f, 210.489441f, 4.87731934f, -137.297943f, 156.094116f, -363.924133f, -97.94849f, 437.2954f);
            float2x4 b0 = float2x4(-474.814148f, 304.371033f, 234.824158f, -390.485443f, -297.175354f, -326.2924f, 107.253906f, -413.131073f);
            bool2x4 r0 = bool2x4(false, true, true, false, false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x4 a1 = float2x4(458.530273f, -294.064758f, 23.62262f, -34.2840576f, 149.736511f, -418.8867f, -197.502533f, -88.2055054f);
            float2x4 b1 = float2x4(67.09442f, 470.075256f, -84.499115f, 392.784241f, -263.531738f, 369.3009f, -333.3253f, 238.413452f);
            bool2x4 r1 = bool2x4(false, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x4 a2 = float2x4(-376.71814f, 341.627136f, -83.30917f, -107.490723f, 319.466858f, 205.357361f, 345.563721f, 395.3219f);
            float2x4 b2 = float2x4(486.2426f, 279.6502f, 236.052f, 132.758972f, 66.29474f, 183.002136f, 200.130554f, 339.043823f);
            bool2x4 r2 = bool2x4(true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x4 a3 = float2x4(-222.874146f, 439.022034f, -368.075562f, -200.0386f, 71.46991f, -357.365417f, 141.710876f, 319.0171f);
            float2x4 b3 = float2x4(438.5379f, 145.401855f, 178.163086f, 157.975952f, 329.7052f, -243.590912f, 5.401184f, -22.5805969f);
            bool2x4 r3 = bool2x4(true, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x4_operator_less_equal_wide_scalar()
        {
            float2x4 a0 = float2x4(193.49585f, 168.915527f, -313.993073f, 81.8269653f, 18.5036011f, -0.3581848f, 241.361145f, -463.8164f);
            float b0 = (443.850525f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x4 a1 = float2x4(-1.35775757f, 398.991943f, -471.253082f, -264.9378f, 82.2583f, 11.2460327f, 424.704041f, 426.482239f);
            float b1 = (-268.899475f);
            bool2x4 r1 = bool2x4(false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x4 a2 = float2x4(56.3200073f, 31.9011841f, -152.257568f, -437.926453f, -37.1048279f, -47.1442261f, 333.623047f, -274.8039f);
            float b2 = (-196.2879f);
            bool2x4 r2 = bool2x4(false, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x4 a3 = float2x4(358.67627f, 192.309143f, 145.306091f, -466.132965f, -494.267334f, -111.570129f, -139.5412f, -146.589355f);
            float b3 = (-260.460571f);
            bool2x4 r3 = bool2x4(false, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x4_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float2x4 b0 = float2x4(-75.6883545f, -44.2638855f, 125.864929f, 191.9649f, 13.54303f, -197.051941f, -423.9451f, -330.0486f);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (420.165527f);
            float2x4 b1 = float2x4(105.5473f, 174.821289f, 296.7176f, -469.7004f, 123.267212f, 112.996948f, 495.143372f, -488.6579f);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (388.539429f);
            float2x4 b2 = float2x4(-493.240784f, 16.45105f, -387.651642f, -229.1773f, -373.01532f, -391.142151f, 90.99414f, -178.396149f);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-69.62106f);
            float2x4 b3 = float2x4(471.790833f, -67.46677f, 45.30536f, -154.6922f, 385.7389f, -431.652954f, -331.673035f, -349.8927f);
            bool2x4 r3 = bool2x4(true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_equal_wide_wide()
        {
            float2x4 a0 = float2x4(-507.9286f, 504.4975f, -385.4345f, -262.323425f, -37.5509338f, -111.595276f, -463.702026f, 387.448853f);
            float2x4 b0 = float2x4(-81.3465f, 297.666138f, 171.06543f, -431.038055f, -6.85907f, 319.7257f, 254.079163f, 396.5724f);
            bool2x4 r0 = bool2x4(false, true, false, true, false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x4 a1 = float2x4(456.9688f, -211.010162f, 182.411377f, -53.59604f, -309.570221f, -136.022491f, 280.736267f, -96.99588f);
            float2x4 b1 = float2x4(178.8393f, -447.063354f, 288.492676f, 474.889282f, -321.750244f, -395.977234f, -158.692474f, 391.4887f);
            bool2x4 r1 = bool2x4(true, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x4 a2 = float2x4(-174.059509f, 88.90192f, 43.81604f, -446.07843f, 16.6455688f, 409.83252f, -191.329865f, 222.9978f);
            float2x4 b2 = float2x4(-368.109253f, 89.12378f, -510.279327f, -486.9298f, -81.2155457f, 274.2188f, -212.881561f, 288.9953f);
            bool2x4 r2 = bool2x4(true, false, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x4 a3 = float2x4(404.2884f, 230.603271f, -441.789276f, -86.29306f, 484.249573f, 95.23639f, -204.912109f, -199.774353f);
            float2x4 b3 = float2x4(307.73175f, 307.245178f, -199.391785f, -284.421265f, -482.3918f, 448.315735f, -378.3462f, -390.858459f);
            bool2x4 r3 = bool2x4(true, false, false, true, true, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_equal_wide_scalar()
        {
            float2x4 a0 = float2x4(465.152161f, -424.886078f, -209.2211f, 58.7798462f, -302.2691f, 140.12561f, 16.3533936f, -344.559967f);
            float b0 = (-5.599884f);
            bool2x4 r0 = bool2x4(true, false, false, true, false, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x4 a1 = float2x4(393.278076f, 441.011536f, -509.781555f, -36.9942932f, 494.8203f, -164.973938f, -466.1201f, -123.813751f);
            float b1 = (-315.701538f);
            bool2x4 r1 = bool2x4(true, true, false, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x4 a2 = float2x4(215.651245f, 314.346f, 190.516113f, -83.11142f, -23.8364258f, 143.049377f, -264.919983f, -169.702209f);
            float b2 = (104.995728f);
            bool2x4 r2 = bool2x4(true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x4 a3 = float2x4(329.70752f, -260.4233f, 354.195129f, -111.845337f, 33.309082f, 355.6313f, -435.360565f, -38.3993225f);
            float b3 = (359.095825f);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x4_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float2x4 b0 = float2x4(-1.60977173f, 338.615234f, -116.1814f, -332.157318f, -355.97937f, -468.901428f, 38.579895f, -332.347534f);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (2.89013672f);
            float2x4 b1 = float2x4(467.777771f, 121.406372f, -305.023376f, -58.4288025f, -226.519562f, -47.0209961f, 305.302673f, -427.401245f);
            bool2x4 r1 = bool2x4(false, false, true, true, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (92.26367f);
            float2x4 b2 = float2x4(-497.178528f, -408.625641f, -455.2305f, 396.4261f, -469.2949f, -485.754028f, -182.346191f, -291.545349f);
            bool2x4 r2 = bool2x4(true, true, true, false, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (278.740784f);
            float2x4 b3 = float2x4(-75.8711243f, 28.9070435f, 287.720154f, 420.509766f, 473.626831f, 181.514526f, -369.202881f, 243.749756f);
            bool2x4 r3 = bool2x4(true, true, false, false, false, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x4_operator_add_wide_wide()
        {
            float2x4 a0 = float2x4(506.129028f, -501.779816f, 420.084778f, -186.032074f, -9.312408f, 328.51178f, 424.344055f, 87.79108f);
            float2x4 b0 = float2x4(-28.7579956f, -337.135132f, -340.676819f, 152.312012f, 423.66748f, 90.3740845f, 376.18866f, 1.76721191f);
            float2x4 r0 = float2x4(477.371033f, -838.9149f, 79.40796f, -33.7200623f, 414.355072f, 418.885864f, 800.5327f, 89.55829f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x4 a1 = float2x4(462.4137f, -46.17871f, 401.170044f, -454.124146f, 69.19568f, -177.957336f, 299.604126f, 340.704834f);
            float2x4 b1 = float2x4(-120.185852f, -279.629364f, -344.6671f, 242.839172f, 418.593079f, -23.3128052f, -95.0999451f, 147.9281f);
            float2x4 r1 = float2x4(342.227844f, -325.808075f, 56.50293f, -211.284973f, 487.788757f, -201.270142f, 204.504181f, 488.632935f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x4 a2 = float2x4(219.916016f, -321.9084f, 286.355347f, -333.4195f, -118.932159f, 68.60748f, 23.190918f, -205.577881f);
            float2x4 b2 = float2x4(331.0329f, -82.50256f, 279.4496f, 342.622742f, -300.358521f, -209.694092f, 446.559448f, -351.9892f);
            float2x4 r2 = float2x4(550.9489f, -404.41095f, 565.804932f, 9.203247f, -419.29068f, -141.086609f, 469.750366f, -557.5671f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x4 a3 = float2x4(11.5214233f, -340.795074f, -68.93118f, 304.8532f, -86.63385f, 105.669128f, 349.280518f, 364.7079f);
            float2x4 b3 = float2x4(-263.12384f, -252.458557f, 289.825378f, 338.796143f, -232.619019f, -510.50824f, 349.280762f, -426.212463f);
            float2x4 r3 = float2x4(-251.602417f, -593.253662f, 220.8942f, 643.649353f, -319.252869f, -404.8391f, 698.5613f, -61.5045776f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x4_operator_add_wide_scalar()
        {
            float2x4 a0 = float2x4(-194.514191f, 338.5484f, 246.971375f, 100.510925f, -45.72467f, -478.1113f, 30.9161377f, 60.37433f);
            float b0 = (124.121704f);
            float2x4 r0 = float2x4(-70.39249f, 462.6701f, 371.093079f, 224.632629f, 78.39703f, -353.9896f, 155.037842f, 184.496033f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x4 a1 = float2x4(-242.118744f, 6.79937744f, -484.6998f, -188.265015f, -213.526733f, -267.7843f, 189.259949f, 198.533569f);
            float b1 = (82.50134f);
            float2x4 r1 = float2x4(-159.6174f, 89.30072f, -402.198456f, -105.763672f, -131.025391f, -185.282959f, 271.7613f, 281.0349f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x4 a2 = float2x4(187.536072f, 302.102356f, 300.3991f, 124.021606f, -200.161346f, 31.3782349f, 362.522156f, -423.988861f);
            float b2 = (-424.925659f);
            float2x4 r2 = float2x4(-237.389587f, -122.8233f, -124.52655f, -300.904053f, -625.087036f, -393.547424f, -62.4035034f, -848.914551f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x4 a3 = float2x4(432.41333f, -465.6995f, -311.04303f, 84.91901f, -432.442444f, 235.750671f, -472.637756f, -257.577759f);
            float b3 = (374.211426f);
            float2x4 r3 = float2x4(806.624756f, -91.48807f, 63.168396f, 459.130432f, -58.2310181f, 609.9621f, -98.42633f, 116.633667f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x4_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float2x4 b0 = float2x4(511.362244f, -146.216644f, -106.210419f, -363.450256f, 199.0896f, -27.1083984f, 419.849f, 284.955017f);
            float2x4 r0 = float2x4(171.007568f, -486.57132f, -446.5651f, -703.804932f, -141.265076f, -367.463074f, 79.49432f, -55.39966f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-164.9242f);
            float2x4 b1 = float2x4(-249.190338f, 150.928162f, 298.1751f, -457.1534f, 424.718079f, -301.857483f, 230.288879f, -423.5876f);
            float2x4 r1 = float2x4(-414.114532f, -13.9960327f, 133.250916f, -622.077637f, 259.793884f, -466.781677f, 65.3646851f, -588.5118f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-67.06003f);
            float2x4 b2 = float2x4(68.72412f, -164.02243f, 318.935181f, 7.80456543f, 187.698364f, -3.656952f, -446.083069f, -209.287231f);
            float2x4 r2 = float2x4(1.664093f, -231.082458f, 251.875153f, -59.2554626f, 120.638336f, -70.71698f, -513.143066f, -276.34726f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-38.21289f);
            float2x4 b3 = float2x4(-346.257172f, 465.607422f, -192.185944f, 278.6938f, 381.978455f, 481.243652f, -97.22815f, -455.513733f);
            float2x4 r3 = float2x4(-384.470062f, 427.394531f, -230.398834f, 240.4809f, 343.765564f, 443.030762f, -135.44104f, -493.726624f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x4_operator_sub_wide_wide()
        {
            float2x4 a0 = float2x4(160.492249f, 11.223938f, 359.200134f, -498.2283f, -355.253632f, -94.53485f, -410.46405f, -401.384644f);
            float2x4 b0 = float2x4(115.46875f, -130.9823f, 241.540833f, 9.987061f, 419.895142f, 59.12445f, -402.381653f, -75.37015f);
            float2x4 r0 = float2x4(45.0235f, 142.206238f, 117.6593f, -508.215363f, -775.1488f, -153.6593f, -8.082397f, -326.0145f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x4 a1 = float2x4(317.706848f, 447.060425f, -489.074158f, -230.008392f, 24.8754272f, 366.614441f, -107.374146f, -219.008148f);
            float2x4 b1 = float2x4(320.9796f, -73.90875f, -31.4447327f, -389.251953f, -375.028839f, 259.182739f, 276.648682f, -453.0692f);
            float2x4 r1 = float2x4(-3.272766f, 520.9692f, -457.629425f, 159.243561f, 399.904266f, 107.4317f, -384.022827f, 234.061066f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x4 a2 = float2x4(473.9076f, 259.63623f, -360.119629f, 7.80963135f, 437.428467f, -59.1991577f, 418.744324f, 183.142151f);
            float2x4 b2 = float2x4(-272.576538f, -191.148041f, 87.1369f, 430.02478f, 343.6571f, 121.029419f, -354.188171f, 249.052f);
            float2x4 r2 = float2x4(746.484131f, 450.784271f, -447.256531f, -422.215149f, 93.77136f, -180.228577f, 772.9325f, -65.90985f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x4 a3 = float2x4(271.230347f, 496.208557f, 165.354919f, -227.403656f, -166.522858f, 356.142273f, 386.9264f, -394.638763f);
            float2x4 b3 = float2x4(-2.22543335f, 22.4472656f, 478.112976f, -320.063f, -111.524109f, 222.228943f, -245.411072f, -119.902283f);
            float2x4 r3 = float2x4(273.45578f, 473.7613f, -312.758057f, 92.65933f, -54.99875f, 133.91333f, 632.337463f, -274.736481f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x4_operator_sub_wide_scalar()
        {
            float2x4 a0 = float2x4(207.389587f, 248.457764f, -384.8239f, -205.344757f, -374.811554f, 191.642029f, 18.8562622f, -44.96161f);
            float b0 = (-36.1124878f);
            float2x4 r0 = float2x4(243.502075f, 284.570251f, -348.711426f, -169.232269f, -338.699066f, 227.754517f, 54.96875f, -8.849121f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x4 a1 = float2x4(480.857971f, -366.865448f, -35.5231f, 349.397766f, 439.077271f, 490.2223f, 195.024048f, -384.849426f);
            float b1 = (16.3381958f);
            float2x4 r1 = float2x4(464.519775f, -383.203644f, -51.8612976f, 333.05957f, 422.739075f, 473.8841f, 178.685852f, -401.187622f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x4 a2 = float2x4(189.05188f, -54.931488f, 53.0880737f, 316.8025f, -273.8067f, 256.8872f, 297.173645f, 101.829041f);
            float b2 = (55.6027832f);
            float2x4 r2 = float2x4(133.4491f, -110.534271f, -2.51470947f, 261.1997f, -329.4095f, 201.284424f, 241.570862f, 46.2262573f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x4 a3 = float2x4(136.607971f, 336.589722f, -51.8765564f, 317.345764f, -467.055939f, -50.1670532f, 477.804565f, -60.82193f);
            float b3 = (-19.7322083f);
            float2x4 r3 = float2x4(156.340179f, 356.32193f, -32.14435f, 337.077972f, -447.32373f, -30.434845f, 497.536774f, -41.08972f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x4_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float2x4 b0 = float2x4(466.4251f, 298.486938f, -300.9501f, 315.38f, -381.092163f, -125.008362f, 58.4661865f, 214.7461f);
            float2x4 r0 = float2x4(-552.43335f, -384.495178f, 214.941864f, -401.388245f, 295.083923f, 39.0001221f, -144.474426f, -300.754333f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-257.549438f);
            float2x4 b1 = float2x4(480.2246f, -443.355072f, 260.795044f, 29.6819458f, 139.857727f, -247.789948f, -248.466217f, 91.44513f);
            float2x4 r1 = float2x4(-737.774048f, 185.805634f, -518.3445f, -287.231384f, -397.407166f, -9.759491f, -9.083221f, -348.994568f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (86.3841553f);
            float2x4 b2 = float2x4(373.8183f, 260.411926f, 114.353943f, -464.405457f, -109.741455f, -311.675354f, 107.864014f, -258.795166f);
            float2x4 r2 = float2x4(-287.434143f, -174.027771f, -27.9697876f, 550.7896f, 196.12561f, 398.0595f, -21.4798584f, 345.179321f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (14.0975342f);
            float2x4 b3 = float2x4(-461.970184f, 30.3108521f, 63.70111f, -462.676758f, 39.75946f, 47.99817f, -177.6193f, 202.477051f);
            float2x4 r3 = float2x4(476.067719f, -16.2133179f, -49.6035767f, 476.7743f, -25.6619263f, -33.9006348f, 191.716827f, -188.379517f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x4_operator_mul_wide_wide()
        {
            float2x4 a0 = float2x4(-482.7138f, -407.2935f, 137.700562f, 208.541138f, 194.29657f, -484.242432f, 183.9873f, -241.33548f);
            float2x4 b0 = float2x4(-236.367889f, 260.7276f, -416.3863f, -364.4956f, -253.147522f, -369.202881f, 193.547913f, 169.0849f);
            float2x4 r0 = float2x4(114098.047f, -106192.656f, -57336.625f, -76012.33f, -49185.6953f, 178783.7f, 35610.36f, -40806.1836f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x4 a1 = float2x4(45.8687744f, 363.3261f, -328.118958f, -471.023071f, -262.682556f, -379.262756f, -374.090576f, 481.4474f);
            float2x4 b1 = float2x4(201.969666f, 249.456055f, -308.193176f, -385.579651f, -183.2796f, 22.2756348f, -265.521423f, -95.67746f);
            float2x4 r1 = float2x4(9264.101f, 90633.9f, 101124.023f, 181616.9f, 48144.3555f, -8448.318f, 99329.06f, -46063.6641f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x4 a2 = float2x4(104.628052f, 412.935425f, 477.877258f, 20.3778076f, 291.995972f, -138.488312f, -393.464966f, 9.363098f);
            float2x4 b2 = float2x4(133.2544f, 148.311462f, 249.284119f, 500.0055f, -19.3315735f, -36.69107f, 30.5238037f, -401.367f);
            float2x4 r2 = float2x4(13942.1475f, 61243.06f, 119127.211f, 10189.0156f, -5644.7417f, 5081.284f, -12010.0479f, -3758.03857f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x4 a3 = float2x4(-131.942291f, 364.449646f, 390.615967f, 418.797974f, -277.3448f, 11.4101563f, 474.876465f, -502.405029f);
            float2x4 b3 = float2x4(3.43725586f, 257.24176f, -290.971924f, 337.47937f, 490.286133f, -191.0198f, -325.7345f, -52.1819763f);
            float2x4 r3 = float2x4(-453.5194f, 93751.67f, -113658.281f, 141335.672f, -135978.3f, -2179.566f, -154683.641f, 26216.4883f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x4_operator_mul_wide_scalar()
        {
            float2x4 a0 = float2x4(-96.31882f, -277.142273f, -239.93689f, 509.531433f, 255.8581f, 215.7315f, -455.50827f, -389.2433f);
            float b0 = (-301.2072f);
            float2x4 r0 = float2x4(29011.9219f, 83477.25f, 72270.72f, -153474.547f, -77066.3047f, -64979.8867f, 137202.375f, 117242.883f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x4 a1 = float2x4(-338.29248f, 243.757324f, 135.354675f, -207.3501f, -383.9396f, -31.4252319f, 42.6761475f, 260.38385f);
            float b1 = (53.7962646f);
            float2x4 r1 = float2x4(-18198.8711f, 13113.2334f, 7281.576f, -11154.6611f, -20654.5176f, -1690.56f, 2295.81738f, 14007.6787f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x4 a2 = float2x4(176.867554f, -290.5006f, 207.091f, -156.523315f, -208.402008f, 370.945068f, -341.59845f, 10.2703247f);
            float b2 = (25.67212f);
            float2x4 r2 = float2x4(4540.565f, -7457.766f, 5316.465f, -4018.28516f, -5350.121f, 9522.946f, -8769.556f, 263.661f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x4 a3 = float2x4(-176.888763f, 186.279785f, -487.652222f, -129.376831f, -317.7163f, -207.62735f, 388.8714f, -233.335327f);
            float b3 = (-61.0061035f);
            float2x4 r3 = float2x4(10791.2939f, -11364.2041f, 29749.7617f, 7892.77637f, 19382.6348f, 12666.5352f, -23723.53f, 14234.8789f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x4_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float2x4 b0 = float2x4(96.74756f, 492.185364f, -274.054565f, -452.870972f, 420.853333f, 102.182922f, -114.948883f, -351.120056f);
            float2x4 r0 = float2x4(3621.473f, 18423.5762f, -10258.4629f, -16951.9531f, 15753.4619f, 3824.93066f, -4302.78857f, -13143.1924f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-464.664978f);
            float2x4 b1 = float2x4(444.084839f, 447.1053f, 130.829346f, -321.41333f, 445.301331f, 478.2436f, 358.571716f, -144.8901f);
            float2x4 r1 = float2x4(-206350.672f, -207754.172f, -60791.8164f, 149349.516f, -206915.938f, -222223.047f, -166615.719f, 67325.36f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-438.893829f);
            float2x4 b2 = float2x4(-3.536438f, -471.807556f, -42.5603943f, 119.911072f, 271.900024f, 239.684021f, 487.4414f, -79.18829f);
            float2x4 r2 = float2x4(1552.12085f, 207073.422f, 18679.4941f, -52628.23f, -119335.242f, -105195.836f, -213935.031f, 34755.2539f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-112.925659f);
            float2x4 b3 = float2x4(161.370056f, 459.759155f, -337.195984f, -276.834534f, 469.723877f, -274.565155f, 506.7859f, 65.88257f);
            float2x4 r3 = float2x4(-18222.82f, -51918.6055f, 38078.08f, 31261.7227f, -53043.88f, 31005.4512f, -57229.13f, -7439.83252f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x4_operator_div_wide_wide()
        {
            float2x4 a0 = float2x4(-353.131439f, -102.799866f, 51.3191528f, -191.871674f, 8.041809f, -128.73764f, -136.0596f, -370.471f);
            float2x4 b0 = float2x4(-178.739563f, -302.096283f, -199.405823f, 278.850769f, 502.3376f, -361.484833f, 353.121033f, -38.894928f);
            float2x4 r0 = float2x4(1.97567582f, 0.34028843f, -0.257360339f, -0.688080132f, 0.0160087738f, 0.356135666f, -0.385305852f, 9.524919f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x4 a1 = float2x4(-237.69455f, -432.546875f, 200.2655f, 361.4416f, -416.226135f, -450.0192f, -273.497437f, -286.908173f);
            float2x4 b1 = float2x4(-75.76474f, -195.217834f, -405.034f, -394.23f, -375.8277f, -121.245483f, 447.623352f, 338.286255f);
            float2x4 r1 = float2x4(3.1372714f, 2.215714f, -0.4944412f, -0.9168292f, 1.107492f, 3.71163678f, -0.610999048f, -0.8481225f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x4 a2 = float2x4(-314.256042f, 177.762085f, 97.6270142f, -68.10727f, -386.450745f, 263.699341f, -297.0271f, -501.777039f);
            float2x4 b2 = float2x4(-405.5442f, -431.168945f, 296.205139f, 437.939819f, 39.2106323f, 331.289734f, -310.619568f, 207.26947f);
            float2x4 r2 = float2x4(0.7748996f, -0.412279427f, 0.3295926f, -0.155517414f, -9.855764f, 0.795978f, 0.9562408f, -2.42089224f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x4 a3 = float2x4(-263.40686f, -451.080841f, -416.34552f, -315.278748f, -28.1811218f, -397.870148f, -261.386658f, 40.3482056f);
            float2x4 b3 = float2x4(-223.293f, -480.0914f, 448.675964f, -460.097443f, -220.569855f, -84.85315f, 441.373779f, 72.41846f);
            float2x4 r3 = float2x4(1.17964673f, 0.9395729f, -0.9279426f, 0.6852434f, 0.127765059f, 4.688926f, -0.592211545f, 0.557153642f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x4_operator_div_wide_scalar()
        {
            float2x4 a0 = float2x4(171.3424f, 0.103393555f, 57.8882446f, -256.130737f, 95.66968f, -290.3869f, -127.4487f, -79.7449f);
            float b0 = (171.796814f);
            float2x4 r0 = float2x4(0.997355f, 0.000601836247f, 0.3369576f, -1.49089336f, 0.5568769f, -1.69029272f, -0.7418572f, -0.4641815f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x4 a1 = float2x4(146.466858f, 58.68634f, -453.2058f, -205.033813f, 481.738159f, 464.479065f, -293.4635f, -158.505585f);
            float b1 = (-499.843567f);
            float2x4 r1 = float2x4(-0.2930254f, -0.117409416f, 0.9066953f, 0.410195976f, -0.96377784f, -0.929248869f, 0.5871107f, 0.3171104f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x4 a2 = float2x4(-289.5822f, 203.583435f, 180.9704f, 259.1192f, 460.844727f, 490.956238f, -280.478058f, -320.243866f);
            float b2 = (494.1286f);
            float2x4 r2 = float2x4(-0.5860463f, 0.412004948f, 0.366241485f, 0.5243963f, 0.932641268f, 0.993579865f, -0.5676216f, -0.64809823f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x4 a3 = float2x4(192.41449f, 226.852966f, -192.235687f, 460.9765f, -437.8922f, -413.232727f, 249.471863f, 313.035034f);
            float b3 = (264.800842f);
            float2x4 r3 = float2x4(0.7266385f, 0.8566928f, -0.7259633f, 1.74084222f, -1.65366626f, -1.56054163f, 0.9421113f, 1.18215275f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x4_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float2x4 b0 = float2x4(105.589111f, -142.349091f, -288.9489f, 39.644104f, -363.9914f, -149.718231f, -395.729126f, 258.7187f);
            float2x4 r0 = float2x4(-2.50444865f, 1.85770416f, 0.9151877f, -6.670412f, 0.7265076f, 1.7662679f, 0.6682412f, -1.02212369f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-9.66626f);
            float2x4 b1 = float2x4(117.725525f, -331.386536f, -509.986023f, 427.896484f, 467.617126f, -407.124634f, 252.690735f, 444.599365f);
            float2x4 r1 = float2x4(-0.0821084455f, 0.0291691385f, 0.01895397f, -0.0225901827f, -0.0206713118f, 0.023742754f, -0.0382533222f, -0.0217415057f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-88.31329f);
            float2x4 b2 = float2x4(199.955017f, -218.346924f, -13.4171753f, -296.131073f, 0.561340332f, -289.299316f, 196.218323f, 334.733459f);
            float2x4 r2 = float2x4(-0.4416658f, 0.4044632f, 6.58210754f, 0.298223674f, -157.32576f, 0.305266172f, -0.4500767f, -0.263831675f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-282.392731f);
            float2x4 b3 = float2x4(-479.5036f, -473.439453f, 105.050781f, -287.6313f, 77.29932f, -210.894379f, -184.068237f, -315.148438f);
            float2x4 r3 = float2x4(0.5889272f, 0.596470654f, -2.68815446f, 0.981787264f, -3.653237f, 1.33902442f, 1.5341742f, 0.8960626f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x4_operator_mod_wide_wide()
        {
            float2x4 a0 = float2x4(-388.8125f, 181.681213f, -167.078735f, 432.820129f, -258.438965f, -170.110809f, 283.3183f, 122.716492f);
            float2x4 b0 = float2x4(436.944153f, 58.9400635f, -201.116241f, 279.289368f, -397.079773f, 377.899963f, 174.693848f, -228.176514f);
            float2x4 r0 = float2x4(-388.8125f, 4.861023f, -167.078735f, 153.530762f, -258.438965f, -170.110809f, 108.624451f, 122.716492f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x4 a1 = float2x4(335.271f, -503.608521f, 191.022522f, 289.742676f, -124.033722f, 259.274f, -274.358459f, -140.030792f);
            float2x4 b1 = float2x4(-317.060181f, -417.4801f, -249.975952f, -397.571564f, -358.745453f, -198.15921f, 208.737122f, -12.1194153f);
            float2x4 r1 = float2x4(18.2108154f, -86.12842f, 191.022522f, 289.742676f, -124.033722f, 61.1147766f, -65.62134f, -6.717224f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x4 a2 = float2x4(324.577576f, -200.513092f, 211.423157f, -51.2722168f, -230.633911f, 99.98938f, 399.18988f, 24.90326f);
            float2x4 b2 = float2x4(25.2714233f, -194.1207f, -493.8718f, -312.3017f, -216.980591f, 413.570984f, -436.3944f, 3.491272f);
            float2x4 r2 = float2x4(21.3204956f, -6.392395f, 211.423157f, -51.2722168f, -13.65332f, 99.98938f, 399.18988f, 0.464355469f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x4 a3 = float2x4(50.92401f, -364.863678f, -252.626617f, -281.2898f, -364.798523f, -329.026245f, 51.6098022f, 41.6478271f);
            float2x4 b3 = float2x4(-308.233429f, -441.375061f, 84.60083f, 373.163452f, 67.25275f, -320.333282f, 118.97937f, 44.8239746f);
            float2x4 r3 = float2x4(50.92401f, -364.863678f, -83.42496f, -281.2898f, -28.53479f, -8.692963f, 51.6098022f, 41.6478271f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x4_operator_mod_wide_scalar()
        {
            float2x4 a0 = float2x4(-244.499634f, -211.8193f, -145.926788f, -304.9182f, 155.479492f, -133.907776f, 281.309631f, -226.535767f);
            float b0 = (39.63495f);
            float2x4 r0 = float2x4(-6.68994141f, -13.6445618f, -27.0219421f, -27.4735718f, 36.574646f, -15.00293f, 3.86499023f, -28.3610229f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x4 a1 = float2x4(335.166138f, 319.4715f, -285.4023f, -355.846863f, 259.378f, -330.871948f, -284.343567f, -102.683441f);
            float b1 = (101.706482f);
            float2x4 r1 = float2x4(30.0466919f, 14.3520508f, -81.98935f, -50.727417f, 55.9650269f, -25.7525024f, -80.9306f, -0.9769592f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x4 a2 = float2x4(-172.141754f, -416.713654f, -339.256653f, 435.2975f, 132.552917f, 226.944092f, -306.1183f, 115.438477f);
            float b2 = (206.41687f);
            float2x4 r2 = float2x4(-172.141754f, -3.87991333f, -132.839783f, 22.4637451f, 132.552917f, 20.5272217f, -99.701416f, 115.438477f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x4 a3 = float2x4(281.882935f, -140.0405f, -462.3235f, -211.6087f, 351.331055f, 321.047f, 346.0852f, -94.4077454f);
            float b3 = (-218.347443f);
            float2x4 r3 = float2x4(63.5354919f, -140.0405f, -25.6286011f, -211.6087f, 132.983612f, 102.699554f, 127.737762f, -94.4077454f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x4_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float2x4 b0 = float2x4(-249.7761f, -396.073761f, 386.492065f, 168.939453f, -199.418243f, 261.7517f, 16.1274414f, 257.668152f);
            float2x4 r0 = float2x4(-66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -2.43527222f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-75.78845f);
            float2x4 b1 = float2x4(170.9563f, -242.858276f, 425.9453f, 303.2724f, 3.033081f, -505.74353f, 461.957031f, 205.972778f);
            float2x4 r1 = float2x4(-75.78845f, -75.78845f, -75.78845f, -75.78845f, -2.99450684f, -75.78845f, -75.78845f, -75.78845f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (270.040649f);
            float2x4 b2 = float2x4(-47.4807129f, -150.254486f, 149.499512f, -220.298035f, 31.1188354f, 400.635681f, 6.23144531f, -39.05075f);
            float2x4 r2 = float2x4(32.637085f, 119.786163f, 120.541138f, 49.7426147f, 21.0899658f, 270.040649f, 2.088501f, 35.736145f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-71.9411f);
            float2x4 b3 = float2x4(-495.307129f, -86.7196045f, -436.970062f, -472.294739f, -130.008759f, -251.516846f, 281.976379f, 388.86084f);
            float2x4 r3 = float2x4(-71.9411f, -71.9411f, -71.9411f, -71.9411f, -71.9411f, -71.9411f, -71.9411f, -71.9411f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x4_operator_plus()
        {
            float2x4 a0 = float2x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f);
            float2x4 r0 = float2x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f);
            TestUtils.AreEqual(+a0, r0);

            float2x4 a1 = float2x4(-386.059845f, -418.645264f, 504.474854f, -170.746521f, 439.5594f, -478.7494f, 116.400757f, 421.409668f);
            float2x4 r1 = float2x4(-386.059845f, -418.645264f, 504.474854f, -170.746521f, 439.5594f, -478.7494f, 116.400757f, 421.409668f);
            TestUtils.AreEqual(+a1, r1);

            float2x4 a2 = float2x4(-258.596069f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f, 279.072937f);
            float2x4 r2 = float2x4(-258.596069f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f, 279.072937f);
            TestUtils.AreEqual(+a2, r2);

            float2x4 a3 = float2x4(108.775818f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f, -161.454834f, -355.270874f);
            float2x4 r3 = float2x4(108.775818f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f, -161.454834f, -355.270874f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float2x4_operator_neg()
        {
            float2x4 a0 = float2x4(148.461731f, -467.122681f, 132.04718f, 183.522644f, 473.701f, -407.9911f, -54.95877f, -382.9898f);
            float2x4 r0 = float2x4(-148.461731f, 467.122681f, -132.04718f, -183.522644f, -473.701f, 407.9911f, 54.95877f, 382.9898f);
            TestUtils.AreEqual(-a0, r0);

            float2x4 a1 = float2x4(-299.093384f, 407.709778f, 168.735474f, 466.441528f, 171.902466f, -280.558319f, -78.857605f, 318.69635f);
            float2x4 r1 = float2x4(299.093384f, -407.709778f, -168.735474f, -466.441528f, -171.902466f, 280.558319f, 78.857605f, -318.69635f);
            TestUtils.AreEqual(-a1, r1);

            float2x4 a2 = float2x4(-39.9154053f, 132.195618f, -505.895264f, 410.380554f, -237.056946f, -137.617828f, -245.349976f, 422.521362f);
            float2x4 r2 = float2x4(39.9154053f, -132.195618f, 505.895264f, -410.380554f, 237.056946f, 137.617828f, 245.349976f, -422.521362f);
            TestUtils.AreEqual(-a2, r2);

            float2x4 a3 = float2x4(-434.57135f, -466.5663f, 426.894531f, 146.649536f, -391.37207f, 423.237732f, 254.297546f, -114.848907f);
            float2x4 r3 = float2x4(434.57135f, 466.5663f, -426.894531f, -146.649536f, 391.37207f, -423.237732f, -254.297546f, 114.848907f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float2x4_operator_prefix_inc()
        {
            float2x4 a0 = float2x4(-139.842072f, -56.7436523f, -381.955322f, 509.796326f, -222.896332f, 210.319885f, -392.7315f, -300.1941f);
            float2x4 r0 = float2x4(-138.842072f, -55.7436523f, -380.955322f, 510.796326f, -221.896332f, 211.319885f, -391.7315f, -299.1941f);
            TestUtils.AreEqual(++a0, r0);

            float2x4 a1 = float2x4(362.212769f, 130.90918f, -450.230164f, 243.546936f, 46.1920166f, -41.4972839f, 299.1855f, 154.356567f);
            float2x4 r1 = float2x4(363.212769f, 131.90918f, -449.230164f, 244.546936f, 47.1920166f, -40.4972839f, 300.1855f, 155.356567f);
            TestUtils.AreEqual(++a1, r1);

            float2x4 a2 = float2x4(-281.233276f, 92.95776f, 448.602173f, -295.587f, 18.4990845f, -215.711121f, 471.947266f, 257.0766f);
            float2x4 r2 = float2x4(-280.233276f, 93.95776f, 449.602173f, -294.587f, 19.4990845f, -214.711121f, 472.947266f, 258.0766f);
            TestUtils.AreEqual(++a2, r2);

            float2x4 a3 = float2x4(41.6259155f, 243.004761f, -472.619019f, -125.720215f, -477.459564f, 9.89147949f, -76.92285f, -29.7675781f);
            float2x4 r3 = float2x4(42.6259155f, 244.004761f, -471.619019f, -124.720215f, -476.459564f, 10.8914795f, -75.92285f, -28.7675781f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float2x4_operator_postfix_inc()
        {
            float2x4 a0 = float2x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f);
            float2x4 r0 = float2x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f);
            TestUtils.AreEqual(a0++, r0);

            float2x4 a1 = float2x4(167.852112f, -326.1076f, 41.03357f, 128.5304f, 73.15558f, -60.1323853f, -446.229767f, -296.937836f);
            float2x4 r1 = float2x4(167.852112f, -326.1076f, 41.03357f, 128.5304f, 73.15558f, -60.1323853f, -446.229767f, -296.937836f);
            TestUtils.AreEqual(a1++, r1);

            float2x4 a2 = float2x4(267.293823f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f, -298.917175f);
            float2x4 r2 = float2x4(267.293823f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f, -298.917175f);
            TestUtils.AreEqual(a2++, r2);

            float2x4 a3 = float2x4(489.985f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f, 239.596924f, 36.62433f);
            float2x4 r3 = float2x4(489.985f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f, 239.596924f, 36.62433f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float2x4_operator_prefix_dec()
        {
            float2x4 a0 = float2x4(123.128723f, 256.84375f, 156.330811f, 461.737427f, 325.867981f, 392.015625f, 187.874146f, -236.225189f);
            float2x4 r0 = float2x4(122.128723f, 255.84375f, 155.330811f, 460.737427f, 324.867981f, 391.015625f, 186.874146f, -237.225189f);
            TestUtils.AreEqual(--a0, r0);

            float2x4 a1 = float2x4(125.109619f, 45.5366821f, 376.046875f, -363.0755f, -22.0289612f, 248.7901f, 168.095032f, 168.265625f);
            float2x4 r1 = float2x4(124.109619f, 44.5366821f, 375.046875f, -364.0755f, -23.0289612f, 247.7901f, 167.095032f, 167.265625f);
            TestUtils.AreEqual(--a1, r1);

            float2x4 a2 = float2x4(-190.284729f, 183.957947f, 485.6947f, -460.739319f, 89.5698853f, -267.4298f, 201.756226f, -141.216888f);
            float2x4 r2 = float2x4(-191.284729f, 182.957947f, 484.6947f, -461.739319f, 88.5698853f, -268.4298f, 200.756226f, -142.216888f);
            TestUtils.AreEqual(--a2, r2);

            float2x4 a3 = float2x4(-217.4841f, -213.544128f, 180.7406f, -128.3125f, 478.045532f, -454.566132f, -386.898346f, 387.857f);
            float2x4 r3 = float2x4(-218.4841f, -214.544128f, 179.7406f, -129.3125f, 477.045532f, -455.566132f, -387.898346f, 386.857f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float2x4_operator_postfix_dec()
        {
            float2x4 a0 = float2x4(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f);
            float2x4 r0 = float2x4(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f);
            TestUtils.AreEqual(a0--, r0);

            float2x4 a1 = float2x4(-27.8892212f, 156.14032f, 479.9452f, -200.304291f, -445.026947f, 407.420349f, 327.670349f, 48.06018f);
            float2x4 r1 = float2x4(-27.8892212f, 156.14032f, 479.9452f, -200.304291f, -445.026947f, 407.420349f, 327.670349f, 48.06018f);
            TestUtils.AreEqual(a1--, r1);

            float2x4 a2 = float2x4(-209.667969f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f, 159.233582f);
            float2x4 r2 = float2x4(-209.667969f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f, 159.233582f);
            TestUtils.AreEqual(a2--, r2);

            float2x4 a3 = float2x4(-359.456482f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f, 145.896729f, -296.790955f);
            float2x4 r3 = float2x4(-359.456482f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f, 145.896729f, -296.790955f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
