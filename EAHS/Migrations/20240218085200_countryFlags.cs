using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EAHS.Migrations
{
    public partial class countryFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FlagPath",
                table: "Country",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\af.png", new Guid("32ae10a2-6695-44a9-9512-854428f8daa2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\al.png", new Guid("75077454-f240-4517-ac32-b76dcd23e16f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\dz.png", new Guid("da5ddaf0-2e62-4131-b603-b49dc49a6ced") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\as.png", new Guid("83d01df4-1006-401e-a840-66ababbd3217") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ad.png", new Guid("30907d5e-0bdb-4880-8a2a-8c8869feabd7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ao.png", new Guid("d8549dd9-72c2-4182-857c-20a635202dab") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ai.png", new Guid("0aae1258-d17c-49df-ae6a-6fe0721fcc18") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ag.png", new Guid("7ca6e8b9-c6b5-49e6-a855-a91165b25ea0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "GlobalId",
                value: new Guid("1aab4481-983b-4048-9c58-f8943594b82c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\am.png", new Guid("54fe850c-a6ee-4edd-898f-7bd3ad1e6efb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\aw.png", new Guid("b66574b5-7ba1-4e3f-9109-f2ddda818a09") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\au.png", new Guid("6eb9bf92-6eca-4e35-acfc-9aa75160b704") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\at.png", new Guid("c4c8274b-ce4c-491b-8d3f-6f4f5a7d515c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\az.png", new Guid("1ce84c45-ea34-4824-989b-cada54c50d06") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bs.png", new Guid("35681a81-2bf2-4411-9e29-5bca6f4f5a05") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bh.png", new Guid("9520ca8a-d1b2-44e5-b19e-bb01fb1fb5a3") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bd.png", new Guid("10566e85-b26c-4a18-adeb-a2a45bf21172") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bb.png", new Guid("b4a332da-02cf-4af7-bd73-0b9f72979e41") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\by.png", new Guid("8623351b-1266-46b6-bc38-20bf3dbd8ccd") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\be.png", new Guid("8bd48212-796f-4ce4-867d-d90bd65d165c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bz.png", new Guid("f3149a9d-e35e-47c6-8e18-9c81eeea16da") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bj.png", new Guid("9f3fdcf2-cd90-4872-80b5-884c1289640b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bm.png", new Guid("29b19ad5-c8a9-4764-85a3-2ecc23592aab") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bt.png", new Guid("dc101c72-b4f1-4e4f-a5e6-2ab585c2fbc7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ba.png", new Guid("8bb200f2-dd90-461f-9f86-e0d0d108a9c9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bw.png", new Guid("74ea6e05-95f3-4a93-83b4-d449dc3a50cf") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\br.png", new Guid("c4d7af0f-b4cf-4890-85ac-a27dec8e5cbb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\io.png", new Guid("20997864-a3f4-446e-b04a-4f0c40961edf") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bg.png", new Guid("a75a328e-8652-4cd5-9a2a-dfa2835c5626") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bf.png", new Guid("60fa90a3-3fde-4ca6-9974-e39962dc3c80") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bi.png", new Guid("749d07f4-0fbb-44e6-aaf8-a217428cdac7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kh.png", new Guid("3cb31976-108c-4d63-86bd-d9581fc43b89") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cm.png", new Guid("209eef43-6af9-4d87-95fb-cdead6491c2e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ca.png", new Guid("1d57ca44-b1db-4dd3-9299-622732cb151d") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cv.png", new Guid("16dc1e0a-786f-47d8-9499-9ca89b5e8a06") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ky.png", new Guid("4f5e1b20-790c-46ac-bb8e-f67758453750") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cf.png", new Guid("55b880d2-c75c-422d-ac61-9ee0286727ba") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\td.png", new Guid("23e73d8b-a74d-40a6-ab1e-9d08807a5aab") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cl.png", new Guid("9169cb86-47f8-49b2-b1db-806ea366e3a7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cn.png", new Guid("b2c8798b-c554-46f5-b666-86bbea47713e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cx.png", new Guid("7e354e4d-2967-45d8-84b8-990839fee695") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\co.png", new Guid("37caf3ef-cd9f-4ee0-81bd-0cf8d8d06af5") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\km.png", new Guid("cef686bc-33cb-4a41-a22c-f87449d50923") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cg.png", new Guid("7c3d790d-1b56-4bfe-b746-f2c40168ce53") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ck.png", new Guid("cfd2f607-dc4f-4070-ae39-47aacb6ed406") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cr.png", new Guid("b9816d22-4190-445d-9b68-67e897a2c047") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\hr.png", new Guid("71e31d31-9bcf-458e-9665-f726fb841162") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cu.png", new Guid("a1f976b9-ea48-42eb-927e-f2ff2b096d5e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cy.png", new Guid("335b884c-9796-4a97-ba5d-0a37b4d78fb1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cz.png", new Guid("8b2057fb-5d27-481a-9c88-e7d9b685d3c2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\dk.png", new Guid("34e27da5-ffa7-41eb-b20d-c907bf9a3f81") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\dj.png", new Guid("f23b2bd9-3778-43ae-938a-47377230b6cd") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\dm.png", new Guid("c5fb3fb3-54a4-4dcb-a4f4-fa3c1581ab7e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\do.png", new Guid("a42668a3-6a5b-4d93-85e5-62c3e3195c39") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ec.png", new Guid("c150ec6d-0bf3-43e6-968f-66944c2c8fe6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\eg.png", new Guid("04c35be4-02e7-4e68-a9c1-bd242ad552bf") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sv.png", new Guid("32531e47-88a6-43d0-a0d0-2a6930a00a20") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gq.png", new Guid("a7c38f30-b58d-483b-87e9-3eff001e95d0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\er.png", new Guid("965a61e0-c962-4084-9592-2b2867d921de") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ee.png", new Guid("85ea3dff-7553-4f33-bc35-76875864cb88") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\et.png", new Guid("ed495ca7-e5f6-4c3c-a769-a189c1c5dac1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fo.png", new Guid("981dad4b-b7b9-4139-9088-0531dec6c3e7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fj.png", new Guid("46bd5189-0276-4bdf-8eab-bbfa0da65407") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fi.png", new Guid("3e1213f3-578e-4141-9380-54ba1f3985b2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fr.png", new Guid("a0ba3e3b-c15b-4c8d-aa24-3356235aef31") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gf.png", new Guid("6cd25fd8-1e67-4621-8f86-233cfbee8443") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pf.png", new Guid("cab04a2a-52f1-4b05-801b-f2fdd46ef80c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ga.png", new Guid("d3c49142-b394-431f-ae3f-6d529a806a7b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gm.png", new Guid("78bb0890-7aa3-422b-922d-95e56d3819ae") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ge.png", new Guid("f89bfdc0-fa08-4323-8cda-5dcfebec9c36") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\de.png", new Guid("4f0bbf55-7934-4b72-a169-1ada0ebf0be0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gh.png", new Guid("b71d2510-7b64-4d00-9fd6-33cbb5e1dac8") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gi.png", new Guid("bf6a9084-0881-4b2c-a583-00672b664e61") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gr.png", new Guid("c98c3731-e46a-4570-bafc-0ae5c1992413") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gl.png", new Guid("216b985a-7ccb-4d95-9857-55bf5f510bd7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gd.png", new Guid("cb6b1e8a-659d-4346-a232-6e6d8f728934") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gp.png", new Guid("2065b6cb-af56-4792-8d52-c6873677ba33") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gu.png", new Guid("99156ed3-9f2b-41c1-9f20-db867d0fd291") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gt.png", new Guid("112d3c18-567b-4b8f-8622-b73deedd7ce7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gn.png", new Guid("4a4cf53d-990d-48d7-8a99-d3751a367576") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gw.png", new Guid("994bd830-ceab-4be1-b27b-2f4de1cfbfe1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gy.png", new Guid("d8d06a2b-e3d6-4913-ac8e-2c6967899cec") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ht.png", new Guid("81aa788f-c715-4810-969f-3fcd04b504b2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\hn.png", new Guid("e5bb7087-3c32-42d8-9d93-de0c4c2dc1bd") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\hu.png", new Guid("9f656b9a-f13c-4e68-ab8e-177cc1d52de6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\is.png", new Guid("92e66ba9-5440-4dfd-a8eb-ad54e3bd9dd6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\in.png", new Guid("7af330f8-ab5c-47e1-88d2-7971c72ac23c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\id.png", new Guid("d99841e1-258b-43c5-a749-f081d981565c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\iq.png", new Guid("96465366-576d-4438-978b-f7d195804146") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ie.png", new Guid("602ff5f9-451d-4b6e-abf3-4730dd9e8a70") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\il.png", new Guid("3190f5b4-a68d-4149-85de-c2cb79e7427e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\it.png", new Guid("2c1ed427-75ed-48b9-8b83-0774ce5c0d4b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\jm.png", new Guid("e2085230-1b6f-4460-9911-10a48c12044b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\jp.png", new Guid("c75c888e-3f65-4a0e-9f4b-c9e98650a90b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\jo.png", new Guid("92f357d9-4ca5-44fc-a583-90124cda82a5") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kz.png", new Guid("3e4c7197-d863-416d-bba0-e5c12cc328c3") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ke.png", new Guid("140a3c16-7a89-4f64-810a-dbfd37d07240") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ki.png", new Guid("c5a156f6-2300-42e9-ac13-2b9725830d9c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kw.png", new Guid("4ac01d5f-c044-4114-a06a-dd4f77f332de") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kg.png", new Guid("da77b184-196c-464b-93cf-8212e6f00625") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lv.png", new Guid("df18e342-e254-4e0b-b1cc-fdaa9876bcc9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lb.png", new Guid("20c7f29c-74a2-4844-8d4e-087131c10389") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ls.png", new Guid("bb963f3e-52cb-4dbe-9db6-a7133638eb66") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lr.png", new Guid("15e441ac-08ab-42bf-9f56-40684673abda") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\li.png", new Guid("963cb3b0-10bd-492c-b805-1bc6554f91e1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lt.png", new Guid("d7363940-266f-43ff-8d00-5049535ca909") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lu.png", new Guid("f950a738-ccb8-4728-8a28-8935fb6db890") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mg.png", new Guid("ecbe32d7-2c05-4ab8-9676-e255f0e71702") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mw.png", new Guid("a0148f2c-5051-49a7-aa69-2a6b21ba0086") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\my.png", new Guid("30f20aa8-4ea5-4cf6-8358-0ee70c6cf2b9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mv.png", new Guid("787ff423-f04f-4815-934b-c24c9173ef22") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ml.png", new Guid("8e1c15da-16a5-41b2-b618-7ddb2492547e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mt.png", new Guid("eecce738-e1f6-4fdb-8269-76665f296e88") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mh.png", new Guid("8e804117-fd4e-482a-bf76-91bcdd99496a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mq.png", new Guid("d7542490-c5af-478f-8cf8-8a0195642b02") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mr.png", new Guid("b020c58c-108b-4f56-8324-cfde9c975f9a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mu.png", new Guid("a00e7f36-fdc9-4c6e-a9d6-4ab0e025831a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\yt.png", new Guid("bf106b3f-f3c1-43e7-aa26-efc9a72d4533") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mx.png", new Guid("22f007a1-e036-4110-89f9-cb4844f0c8fd") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mc.png", new Guid("0268e66c-93fd-480e-bcfd-f240e60a86f7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mn.png", new Guid("3fab71bf-efa9-4de7-851b-5e92b0fad59e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\me.png", new Guid("8cca72fb-3ca9-41fa-a817-376625a2026f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ms.png", new Guid("2edc6f68-2110-4982-bd40-18247dba4fa5") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ma.png", new Guid("4110e126-e373-4afb-aafd-68bcccaa4749") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mm.png", new Guid("bab39875-a6a0-44c0-95bc-8cb6229252b6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\na.png", new Guid("8edf095d-a6ba-431d-88ba-cf14a1b10266") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nr.png", new Guid("66103790-b6d3-4abb-b6a0-3d1f50f732d0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\np.png", new Guid("452c9737-c339-436a-b41e-5a0eb37be71f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nl.png", new Guid("b075b0ad-826f-4a99-8994-aca117be5ce3") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\an.png", new Guid("71bdb1ae-d859-4443-9c48-dd5d26577e0e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nc.png", new Guid("d300d8d0-db00-46b4-b7ea-89d95105bcb0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nz.png", new Guid("6a677874-2310-4fd0-8f38-ef3838c4cff1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ni.png", new Guid("05c90149-24ee-4df8-ac1a-91c6cb182774") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ne.png", new Guid("0b042ce5-31ea-4028-bd30-500e1e4a0aa2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ng.png", new Guid("94a2c6fd-15bd-4f11-83f9-e783c6ceca34") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nu.png", new Guid("12ff1d2e-2060-4015-a60e-0b7cc7ed2811") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\nf.png", new Guid("c68df3f4-c80a-4852-a6d7-281f2b70b120") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mp.png", new Guid("272925c0-697c-47b4-9d0b-d64c6c927d46") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\no.png", new Guid("99a07dc2-ea9b-46f8-8a80-9d34622bd1ae") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\om.png", new Guid("b31d57d8-7251-412a-b00f-cc5d8b7f9f05") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pk.png", new Guid("6c09e9ec-bc37-4fe2-97c4-35d07fa4614a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pw.png", new Guid("cd127d64-4ab9-47d5-ba47-1e57e72b3464") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pa.png", new Guid("27447d83-948a-485f-b976-167cf9d9bc69") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pg.png", new Guid("7e5a6677-2fb4-4e5a-89f6-271e14563575") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\py.png", new Guid("5ac638a9-c26c-4c3c-be00-ad9f6732def1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pe.png", new Guid("5695ca26-0a91-4ccf-8696-2804f2a923d9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ph.png", new Guid("62543be6-9d77-45c2-9df5-c672a4738d84") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pl.png", new Guid("24b97508-bd4f-4db2-8c8c-236f42ad2b04") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pt.png", new Guid("b22fa5e6-cf59-44d6-886c-8aba1cda7eb8") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pr.png", new Guid("c8e5853b-a1a7-419d-8cde-d1f35370c8d7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\qa.png", new Guid("21b90008-bb87-4410-ae77-cd26e83615c3") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ro.png", new Guid("a4ba4f7e-8991-494e-85fe-9dd259a62a36") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\rw.png", new Guid("2942ab6d-3bcb-47a4-9a10-2bc7d3e4fd8a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ws.png", new Guid("59b004c1-5a18-45d4-b62e-43e2420224c7") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sm.png", new Guid("2a6b4bad-4e97-4428-a77e-5ffcbe8c1099") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sa.png", new Guid("5f564853-64d9-42d6-a225-9bf0bfab694d") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sn.png", new Guid("b8b4dd4c-7fd6-400c-a520-06068cb5bff9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\rs.png", new Guid("e65783e3-61b6-40d9-9e80-cc7e774a66be") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sc.png", new Guid("bbc48c19-3f32-4fa6-a7a4-545213897257") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sl.png", new Guid("60a1627f-b590-4d4d-ae67-2f292ff93573") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sg.png", new Guid("cfa415e4-97ff-469d-97e2-b79c015ae815") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sk.png", new Guid("ef745b88-2c8c-4083-b91f-c0258110a832") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\si.png", new Guid("1f7c0eb3-1f0c-492d-aed7-4b8bf7dbb65c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sb.png", new Guid("0c833ab0-4786-438e-9b8f-6dd2ec9dd62c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\za.png", new Guid("39fc3954-76a2-49d0-a993-114205475251") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gs.png", new Guid("cd8ac172-5722-412d-8abe-6d21df573bbb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\es.png", new Guid("f1e40c29-22af-45a6-9237-4d0768ad8f47") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lk.png", new Guid("02f0f1ff-d7c3-4bca-b535-1dcca41e4c3f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sd.png", new Guid("ba208c91-d785-4f99-8905-5ccfb5a87cb9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sr.png", new Guid("f779c633-2faa-4fe6-be47-8ec80426d2eb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sz.png", new Guid("425cfa02-5e45-492c-ba3b-ad7b21820cac") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\se.png", new Guid("1eb37ac1-5703-495a-92cb-7f600e161bb2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ch.png", new Guid("7f9874de-9541-4fdb-a764-41dfedeb612e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tj.png", new Guid("dd6d39c7-c85e-4821-9011-34a4e6fa4650") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\th.png", new Guid("ad64df81-f370-4264-9cfb-7b71742e71eb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tg.png", new Guid("a5f07d8d-ca59-4c28-8410-d4aea8e0299d") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tk.png", new Guid("60e44b79-b7da-4f60-978d-2c5075929341") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\to.png", new Guid("e4aaf622-0283-46b0-97c5-581486fc6195") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tt.png", new Guid("5d02bc4a-dd42-40c3-b0bf-5e37d8b6047b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tn.png", new Guid("6351ab4b-8ad7-4ef7-9153-b84c5af3659c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tr.png", new Guid("05c2e687-6dba-4efb-8602-68419143ba07") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tm.png", new Guid("1d418f2a-b7b7-4148-ad6d-1795faee0eba") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tc.png", new Guid("edcc7d38-375f-4a31-99da-70db913f4e0a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tv.png", new Guid("0545e1fa-f393-4d62-9b12-d766d9611a38") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ug.png", new Guid("3cbfb214-7aa0-4de8-a33b-18876b927240") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ua.png", new Guid("3cab2d4c-2311-4b7f-a4d4-f109f37cea7f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ae.png", new Guid("54fc255a-8149-44e3-8e89-256f87a10758") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gb.png", new Guid("b226c492-92fd-428e-b3fb-037b0b64b3ec") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\us.png", new Guid("08373ec9-7e82-4d25-a675-be004582760d") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\uy.png", new Guid("a35dc254-c8ab-48f4-ad9b-a87c570869e6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\uz.png", new Guid("675ed7b5-8328-43a9-b896-3cb32b1e27f9") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\vu.png", new Guid("27667477-5d41-441a-9a1f-e9d3b97af4d2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\wf.png", new Guid("14d16b3f-93fc-45b2-89d1-0ed41783c325") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ye.png", new Guid("3cfd5ff4-9b6c-4e11-8d4b-f41d72247132") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\zm.png", new Guid("a657fc23-1ef0-4a9c-af6a-238cdbf522a0") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\zw.png", new Guid("5bc5ec11-0235-4ee7-903f-fa51633b94c5") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ax.png", new Guid("c3a7d32e-3af6-496c-8955-e5fb8c37acce") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\aq.png", new Guid("e38ad89d-b3ef-459d-9a0c-c8ec1ed5684e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bo.png", new Guid("813fccbd-d1c2-4fa2-bcc4-e7a76f55f2cb") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bn.png", new Guid("2bf2543f-13b1-4000-808c-d84dfbc331a4") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cc.png", new Guid("91baf2f5-d204-49b9-a736-42c59de22a00") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\cd.png", new Guid("b250b1b9-cbc5-4914-a1e6-d127d49048f1") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ci.png", new Guid("59fc5071-e763-44c8-a310-cc90d024e21a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fk.png", new Guid("b65e020c-d335-4a5f-a6ec-c21c723db2c8") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\gg.png", new Guid("65eebd7f-ca19-4627-b296-62ab41935163") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\va.png", new Guid("133f9fbc-77d6-428f-9487-c90b6d2242d8") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\hk.png", new Guid("a84dcb1c-4f70-4e77-b3cb-718b766a6111") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ir.png", new Guid("12a0138f-987e-4d23-b23f-2fed9bbb40d6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\im.png", new Guid("c95e724b-fce3-4116-b4cb-d5401c18a6a6") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\je.png", new Guid("169039e7-3a81-461f-a41e-7f8d21a20f4c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kp.png", new Guid("6f8f7c76-08f7-4f9c-99ea-70913df84f25") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kr.png", new Guid("121693aa-fc68-4dc0-a9e6-14c9ff819398") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\la.png", new Guid("9eee7f63-9c52-4463-b7da-09e51c873340") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ly.png", new Guid("07b557fa-e6f0-45bc-a195-a61d5345e265") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mo.png", new Guid("20c1a728-c7ca-4512-a343-de49d8cd2097") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mk.png", new Guid("9c4d8175-41ea-4b66-bf60-e9e822c98ebd") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\fm.png", new Guid("be2d5c93-c20a-459a-87b5-96a304152d66") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\md.png", new Guid("f52a80c8-26f2-4620-be3d-b5926b6d9403") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mz.png", new Guid("5694bad8-d070-48c4-bedc-dbe119f02c04") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ps.png", new Guid("f8a424a1-4fa5-4577-ab5d-8d3236e0cedc") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pn.png", new Guid("7cdfe4f5-5493-42eb-9d9d-a0787c45653a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\re.png", new Guid("be38daa8-3b87-401c-b901-8248188ea60e") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ru.png", new Guid("3a679aab-0063-4048-969b-75994a3dd226") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\bl.png", new Guid("69a4cc7c-532d-4261-bb59-0864ff024810") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sh.png", new Guid("114fad26-e023-49c3-b8ab-47c46fb30e86") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\kn.png", new Guid("93058a3f-3e3a-40d4-8fa3-c9da6c91323a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\lc.png", new Guid("01322654-4404-4a97-91e2-441982ff457a") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\mf.png", new Guid("8033316e-0152-4646-b130-99d125859496") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\pm.png", new Guid("f76a3ddb-9fbf-4deb-a90a-eb3ae6c9c5b2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\vc.png", new Guid("d66a7c9f-56b0-4926-a656-8aeab5cd3ec2") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\st.png", new Guid("2819c02d-9134-4a78-a698-3ab00ca1707f") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\so.png", new Guid("08cd825f-ab87-414e-813e-b3f86226063c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sj.png", new Guid("4385acd1-25a7-4e24-b72a-bf3af1675a6b") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\sy.png", new Guid("cb0c7511-85ba-4664-92ba-3689d047ed7c") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tw.png", new Guid("2e1d561e-5c72-4857-928b-7f3e80ce4c14") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tz.png", new Guid("037c3c4d-a2d5-47d8-b72d-7c405b8a1b32") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\tl.png", new Guid("d9b1c679-8971-41e4-ac41-c50baa7219ed") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\ve.png", new Guid("e5c48f00-119f-47b7-b832-4bb56fdd9d37") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\vn.png", new Guid("5ebe96c2-27cc-471d-87f2-76e5328297bf") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\vg.png", new Guid("8fba4b1d-5e10-40b8-9a65-0dba7dcf6464") });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "FlagPath", "GlobalId" },
                values: new object[] { "wwwroot\\CountryFlags\\vi.png", new Guid("8fa7f3d9-f28d-4a3b-92e4-631107679d7d") });

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("4047a275-66c8-48d5-aca3-5d1eddb5f1d0"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("19b1fd8d-19a5-4274-b4b8-f882ca2794cb"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("6252f71e-bc39-4230-ae40-b0befd6a7dae"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("d8e8971a-158b-49b8-8e2b-76bd24d1409e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlagPath",
                table: "Country");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("1847ae5f-f65b-4c36-a77d-3308f7423e08"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("767a7fe7-3047-4f8f-ae3c-6e68834dacf5"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("af69355e-033a-41f6-a869-316dbc75438d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "GlobalId",
                value: new Guid("deb26b5c-0220-43e8-b84d-35877da844a6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "GlobalId",
                value: new Guid("6932c35c-ac93-4f41-ba30-dfee6324ae0f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "GlobalId",
                value: new Guid("e26b9044-50f6-4434-a661-e04150ecc007"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "GlobalId",
                value: new Guid("f1696438-5364-4795-aaa5-de63af853fa9"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "GlobalId",
                value: new Guid("7d8df3dc-fe40-4bfd-8229-3b2e2c51e2d0"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "GlobalId",
                value: new Guid("a78d0596-a101-4d05-8907-104a74c07e9c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "GlobalId",
                value: new Guid("000955f2-e5a0-442d-9c23-fdbca161d626"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "GlobalId",
                value: new Guid("3a644807-04da-4a40-94cc-a4ad89565f36"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "GlobalId",
                value: new Guid("0b4ebfb0-0852-40d9-8108-b48936228e57"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "GlobalId",
                value: new Guid("be2d86e8-474c-457c-bd5c-ab77aa379abe"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "GlobalId",
                value: new Guid("f722718c-5ea8-4730-91e0-48fe0d2fbacc"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "GlobalId",
                value: new Guid("9ac3fcd8-9cff-4e0e-aa9c-ee096a08213e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "GlobalId",
                value: new Guid("c9d9fa51-0433-4663-a62c-f55eb97d3c91"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "GlobalId",
                value: new Guid("bc993713-9ce3-4711-9f27-031e658f4618"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "GlobalId",
                value: new Guid("964cf17d-1253-44d2-b3e7-8ed1ad142554"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "GlobalId",
                value: new Guid("24166191-01d0-4a1c-a7dc-500ba4a0448e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "GlobalId",
                value: new Guid("7fe3eb94-b570-43ae-bff8-d226556c0335"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "GlobalId",
                value: new Guid("56820a6e-afcc-4dce-bdd0-dbae465ce415"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "GlobalId",
                value: new Guid("30b82a04-af95-4a30-9c9c-e6758bd282f2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "GlobalId",
                value: new Guid("abea5400-7d57-43c2-ac1c-df844c5b8e3b"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "GlobalId",
                value: new Guid("8566f4b0-37a6-4df9-adb4-8832e5baec05"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "GlobalId",
                value: new Guid("9a5ff34f-3f72-4bef-933a-0b054b33a8e0"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "GlobalId",
                value: new Guid("1bc7d11a-7c08-4016-80e3-58fc69387a4f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "GlobalId",
                value: new Guid("0ee178df-5026-4a3c-b1f8-32e52c4be80e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "GlobalId",
                value: new Guid("404ecfb8-e1bd-4345-b32c-3d03dc12d9a7"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "GlobalId",
                value: new Guid("69d36062-1e47-4e41-8c36-2de6a7d13938"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "GlobalId",
                value: new Guid("bf3fbed2-3a31-496e-97ee-49526fc7a91e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "GlobalId",
                value: new Guid("e19e6119-dfa6-4741-85b7-b44d6bcd829d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "GlobalId",
                value: new Guid("907cd74f-7e3b-4415-9561-ec43554a6b7a"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "GlobalId",
                value: new Guid("ed908bd0-49fd-457d-b53f-2f0b4222f2ba"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "GlobalId",
                value: new Guid("294218f3-d923-41d8-a7cd-778cf65d5ea8"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "GlobalId",
                value: new Guid("13226658-a5d6-4312-bf25-0f6eb9108648"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "GlobalId",
                value: new Guid("c1ef7e27-5b98-4487-9836-d684c97b34d4"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                column: "GlobalId",
                value: new Guid("9b58b043-6c59-41ed-af30-fc1abfea7758"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                column: "GlobalId",
                value: new Guid("af1ea620-6171-497e-8089-a2a845b8d69d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                column: "GlobalId",
                value: new Guid("d9720465-201f-48e1-8bd7-7200bb5eaeac"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                column: "GlobalId",
                value: new Guid("5f932489-3336-4878-9e59-49e1baa0a220"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                column: "GlobalId",
                value: new Guid("66fcca85-69ce-4c26-bdff-af5aca02161c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                column: "GlobalId",
                value: new Guid("116193d5-77af-4305-a2a7-5ce2c28a1cf9"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                column: "GlobalId",
                value: new Guid("be4fe77b-eee4-4781-8790-dc0f33095424"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                column: "GlobalId",
                value: new Guid("6e7613fb-f5d2-4f90-8db0-3cd4b6710592"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                column: "GlobalId",
                value: new Guid("39ef9dac-b1a8-4a8c-a145-c1e05af544ac"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                column: "GlobalId",
                value: new Guid("fe92d264-7045-479a-89a8-1a6bdb744f79"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                column: "GlobalId",
                value: new Guid("2c544fb7-8c36-456c-9b98-181f5af4be2a"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                column: "GlobalId",
                value: new Guid("ef56e227-b31b-47ec-9195-cc96edf04891"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                column: "GlobalId",
                value: new Guid("61db4c32-6eb2-4d06-b5df-86e012ba5c93"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                column: "GlobalId",
                value: new Guid("a401a9fc-1b6f-4ecb-b7ac-d87e6fe90592"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                column: "GlobalId",
                value: new Guid("968a2ca1-3f32-43fd-a46b-6490797be462"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                column: "GlobalId",
                value: new Guid("4f5b18df-963f-47e0-b28a-8c799a8f45f1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                column: "GlobalId",
                value: new Guid("1a8b2178-69f3-43ad-8f15-178f472d49e0"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                column: "GlobalId",
                value: new Guid("3b4f14a5-ad28-4b0a-8661-c652fbed84e4"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                column: "GlobalId",
                value: new Guid("7e702a1a-4366-4ab9-a09e-86f917dd4fb1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                column: "GlobalId",
                value: new Guid("55363b86-3513-4d5a-bf92-e71f05d6eb14"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                column: "GlobalId",
                value: new Guid("a9b94765-948f-44cd-85b4-f2df34a3ae2c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                column: "GlobalId",
                value: new Guid("12e04153-4b07-4a92-86d2-160a607c8559"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                column: "GlobalId",
                value: new Guid("cccfd174-de78-4a96-b40f-8bf801446623"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                column: "GlobalId",
                value: new Guid("5a43b5e8-2f5d-42d4-9947-314a0a4a5562"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                column: "GlobalId",
                value: new Guid("648e1ebb-5429-4888-a772-6b25c140d271"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                column: "GlobalId",
                value: new Guid("3fd99002-597b-4aa4-af41-58b5d8ab4136"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                column: "GlobalId",
                value: new Guid("2251f920-556c-43c1-817f-dec42bdf4dac"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                column: "GlobalId",
                value: new Guid("ef54e9b1-74ff-44c6-af0d-06eb9b27baf4"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                column: "GlobalId",
                value: new Guid("c03addd4-7f6d-4f36-a77c-c737f7bd8b8d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                column: "GlobalId",
                value: new Guid("900368c0-67df-4b8d-bbac-0ac88f6a8ef2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                column: "GlobalId",
                value: new Guid("debb42ab-2bf9-40e3-9625-b5510ba93bd9"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                column: "GlobalId",
                value: new Guid("3b0fc979-668c-4ea2-8b0d-bdd0f30648b5"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                column: "GlobalId",
                value: new Guid("308761eb-e273-453d-9f12-5e01faf65dbf"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                column: "GlobalId",
                value: new Guid("0eedcafe-e7e8-4b51-bfed-16aebfa5b3a5"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                column: "GlobalId",
                value: new Guid("37ee9d07-c344-457f-8613-d1e1c7e073b7"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                column: "GlobalId",
                value: new Guid("a2d452f7-85b8-49b4-9eda-acd8caf8e720"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                column: "GlobalId",
                value: new Guid("16be8b5d-1ad8-417d-a0d7-649729c05819"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                column: "GlobalId",
                value: new Guid("6973dc6d-e68d-4c2b-a86c-d78bea2f337c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                column: "GlobalId",
                value: new Guid("283770c8-5a40-42be-94ac-632bba6caeae"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                column: "GlobalId",
                value: new Guid("dec707bf-1047-406a-b82a-795a462d6440"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                column: "GlobalId",
                value: new Guid("a0634a56-4353-45a7-892f-6d9f7803e863"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                column: "GlobalId",
                value: new Guid("14a60552-6916-44d0-82d4-1e570f238c8d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                column: "GlobalId",
                value: new Guid("d571ee60-d384-45fc-ab2b-e8432229e390"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                column: "GlobalId",
                value: new Guid("85df91e2-99a6-4a3f-8e15-fef0565b9395"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                column: "GlobalId",
                value: new Guid("5b58e117-5288-4df4-aa01-4dce4f6b9435"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                column: "GlobalId",
                value: new Guid("09c20e32-9568-4c36-8087-a91d72f2f70a"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                column: "GlobalId",
                value: new Guid("c450827b-4020-46ba-9a7b-6824599e6e0a"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                column: "GlobalId",
                value: new Guid("ea613499-120a-423c-be54-47dabcfbcbe1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                column: "GlobalId",
                value: new Guid("b4b3fa91-38cd-423f-9b3f-ebc8114de116"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                column: "GlobalId",
                value: new Guid("4a798502-2971-49ea-8404-4e3aa6778d82"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                column: "GlobalId",
                value: new Guid("7cd6b2a3-0f4a-49f5-8fb3-be67d9177d43"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                column: "GlobalId",
                value: new Guid("00527757-12d0-48e5-9512-d1e747f38051"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                column: "GlobalId",
                value: new Guid("0800ee88-ff0f-4a42-9c8c-b7c9dc87e7ea"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                column: "GlobalId",
                value: new Guid("e94bbf6e-3d9a-4dc6-bffa-a8be94aad771"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                column: "GlobalId",
                value: new Guid("56679e39-5f25-4f1e-84db-2d0178c7bbe3"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                column: "GlobalId",
                value: new Guid("5ebdf45d-24c3-4f62-a092-f18ea1ff057c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                column: "GlobalId",
                value: new Guid("e4cd6d79-dd8b-4100-b64a-798de328253d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                column: "GlobalId",
                value: new Guid("a1c1a1f8-f486-48e0-b995-468aeec8125b"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                column: "GlobalId",
                value: new Guid("3967dbb2-278d-4356-948e-61bcd61dfd79"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                column: "GlobalId",
                value: new Guid("0e7f47e5-3d1f-4f98-b154-a6adcd2c4688"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                column: "GlobalId",
                value: new Guid("ebd926b9-1468-4de2-bc55-29cd7fb9cdfb"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                column: "GlobalId",
                value: new Guid("8e99462e-5b25-414c-ad32-08753c668b74"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                column: "GlobalId",
                value: new Guid("e42e4497-da5d-41c8-b7e7-ea305d68beeb"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                column: "GlobalId",
                value: new Guid("62b2905b-2cfb-404a-b3ac-92bbfa343be4"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                column: "GlobalId",
                value: new Guid("7934120b-4ab6-49e0-a795-25753fea3f74"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                column: "GlobalId",
                value: new Guid("3c7193f6-bed7-456e-b2f6-bd0903ef2791"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                column: "GlobalId",
                value: new Guid("66e05eec-4f14-4c5e-a00a-05e309b575a6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                column: "GlobalId",
                value: new Guid("448e5ba9-f229-4fc3-9b6c-0f96056f8340"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                column: "GlobalId",
                value: new Guid("5177c0c8-b43d-4d57-9db2-c1ab728b4a4c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                column: "GlobalId",
                value: new Guid("695aa828-7d5a-42e4-b8f5-328895c71fef"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                column: "GlobalId",
                value: new Guid("1ddd86b8-1034-4b2f-96c3-a4c571bac8dc"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                column: "GlobalId",
                value: new Guid("5aab874d-781f-4fb6-9a60-132341ed078d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                column: "GlobalId",
                value: new Guid("37b56ac5-922d-43b9-890d-dde93d6f364f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                column: "GlobalId",
                value: new Guid("debb4629-3152-4a20-be57-b992ef5247ec"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                column: "GlobalId",
                value: new Guid("250602bd-a7dd-4e42-8edc-762009b84a9d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                column: "GlobalId",
                value: new Guid("00229bf7-eb1b-4bd5-8526-77449bf65bfb"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                column: "GlobalId",
                value: new Guid("be185f0e-2eab-40d2-9880-6920f32f9247"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                column: "GlobalId",
                value: new Guid("62852080-74e4-489c-864b-b3ac79865d7f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                column: "GlobalId",
                value: new Guid("59048f87-4611-49d6-9636-510a558fa895"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                column: "GlobalId",
                value: new Guid("3c725d9e-18bf-4f0c-8a1d-3b3762ce6f73"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                column: "GlobalId",
                value: new Guid("6fa91046-c270-4eb5-af56-e1191d0c5030"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                column: "GlobalId",
                value: new Guid("34b3c822-0d86-495d-a74e-cd22fd44af7f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                column: "GlobalId",
                value: new Guid("ff3cc667-39c5-426b-a2d6-6235edd91b09"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                column: "GlobalId",
                value: new Guid("bc102601-f030-4b6d-829c-71364e2bf4a1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                column: "GlobalId",
                value: new Guid("03a50435-30c5-4cc6-9d5b-8e94c7a9f846"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                column: "GlobalId",
                value: new Guid("ab379982-8fca-4512-b680-92ff23467f2f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                column: "GlobalId",
                value: new Guid("e0b3f1c0-f2fa-44a4-a584-8d4c354ec13d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                column: "GlobalId",
                value: new Guid("7ac6bf23-a3f7-447d-afaf-b79f7296c8ae"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                column: "GlobalId",
                value: new Guid("6371ced9-e968-48fc-966c-923b0bbcb32a"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                column: "GlobalId",
                value: new Guid("060500de-2a8e-4854-856d-e921acbab8c9"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                column: "GlobalId",
                value: new Guid("96493380-e9dc-49fd-8ab5-f5098f231b3e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                column: "GlobalId",
                value: new Guid("4c23c5ab-07fd-4e1d-ba3c-1d27724bbff8"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                column: "GlobalId",
                value: new Guid("0833ddea-dc8d-4675-a2e9-f6d3d5fd3a7d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                column: "GlobalId",
                value: new Guid("a6bc31d8-b868-458c-bd99-496e4599ae14"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                column: "GlobalId",
                value: new Guid("980bf32f-bf2a-4608-9e31-d21e4e87f59d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                column: "GlobalId",
                value: new Guid("566c72eb-bb3a-4522-86db-3633a3f577ff"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                column: "GlobalId",
                value: new Guid("d2a6fc37-8692-4977-bd66-8c0ef3095f51"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                column: "GlobalId",
                value: new Guid("754fb50a-ac92-423a-b25a-acbc821930fd"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                column: "GlobalId",
                value: new Guid("34b9741e-729e-4f87-a87a-94c1a4672c56"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                column: "GlobalId",
                value: new Guid("01a9f6a7-873e-465f-a097-f10db2cfba22"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                column: "GlobalId",
                value: new Guid("64dbfbb0-7469-4d03-99c2-8cdbb9c13e37"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                column: "GlobalId",
                value: new Guid("66d5873f-9834-4b32-af5d-9ad235a5b1a2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                column: "GlobalId",
                value: new Guid("f5f6efe3-02db-4cfc-be33-16e9a0e328e4"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                column: "GlobalId",
                value: new Guid("bc33c6d1-280b-4f1a-a845-c32aa6d8e478"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                column: "GlobalId",
                value: new Guid("90248c46-608a-44f2-ad91-82fb25cffd17"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                column: "GlobalId",
                value: new Guid("951d7723-67a7-41af-82b1-e5d8edaf9b6d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                column: "GlobalId",
                value: new Guid("063600fa-7083-493d-981d-ab6c54ba1f24"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                column: "GlobalId",
                value: new Guid("d3b383e5-308b-4205-b750-d12840d069e3"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                column: "GlobalId",
                value: new Guid("55e90e88-c102-4446-8be8-d521742cf33d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                column: "GlobalId",
                value: new Guid("957464d0-ed0f-4a3a-9308-6c7c463dbe44"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                column: "GlobalId",
                value: new Guid("d85e332a-ba40-4505-8a01-8dcad84bfac0"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                column: "GlobalId",
                value: new Guid("f845a76c-0235-4bc1-996c-3711633bf011"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                column: "GlobalId",
                value: new Guid("b579c7e2-7fae-484b-8e4b-d5c34d6cf133"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                column: "GlobalId",
                value: new Guid("bda05b70-58c6-47be-accd-280bca0c7170"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                column: "GlobalId",
                value: new Guid("1cc7b5e8-8e4e-4f90-8a31-7c684fc91707"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                column: "GlobalId",
                value: new Guid("79348ba2-d2fb-4f8c-a0fd-3a6c3e57b5a2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                column: "GlobalId",
                value: new Guid("81fc5970-f1fc-4ca2-9568-c6d5affd7385"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                column: "GlobalId",
                value: new Guid("95fb1f52-9d8b-4d0b-8860-c48246183c43"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "GlobalId",
                value: new Guid("e6897bec-e3a3-4ca4-91f6-dc7de308d7e6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                column: "GlobalId",
                value: new Guid("f8d99655-f225-4323-8e9d-e388871eb573"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                column: "GlobalId",
                value: new Guid("4400eb87-539c-4612-9db0-e6812244cba6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                column: "GlobalId",
                value: new Guid("61af8eed-a98d-493c-aacc-6d21d13d20a7"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                column: "GlobalId",
                value: new Guid("772aefb3-1fd8-4c8f-9ac0-49cfc689d2e5"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                column: "GlobalId",
                value: new Guid("556d0dcd-96db-45d4-9c40-70c135f50596"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                column: "GlobalId",
                value: new Guid("844cca2c-bc87-41c2-9685-9b5236f23572"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                column: "GlobalId",
                value: new Guid("fa0fb65f-cfab-4c8b-a95b-a83c4a2f3860"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                column: "GlobalId",
                value: new Guid("6b75921f-6bab-4bb1-8dff-36db6fe80779"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                column: "GlobalId",
                value: new Guid("59b8015b-036b-47d9-badf-fd91cb11f456"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                column: "GlobalId",
                value: new Guid("8de97254-228b-4a6f-b5f7-39fe689d592b"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                column: "GlobalId",
                value: new Guid("c884840e-1838-4d66-8480-813a4be91b55"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                column: "GlobalId",
                value: new Guid("ad725248-46d6-45ca-bf4c-ffbd1c4794df"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                column: "GlobalId",
                value: new Guid("1a030bd1-69ab-4f27-849f-7e050437f5cd"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                column: "GlobalId",
                value: new Guid("c677a5b3-873f-4283-bc95-a3a6522009bc"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                column: "GlobalId",
                value: new Guid("d471e136-2092-4ae4-ab6d-6a0ad8df3001"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                column: "GlobalId",
                value: new Guid("0a35fd47-b1fa-432e-b8ae-c834a66fd758"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                column: "GlobalId",
                value: new Guid("dcfc1981-cc91-41b2-a217-937c77879af2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                column: "GlobalId",
                value: new Guid("15f00989-ef50-477b-872c-ce667cd6d987"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                column: "GlobalId",
                value: new Guid("161b313a-d550-45da-9565-b10e8dc4950f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                column: "GlobalId",
                value: new Guid("b3299978-d16c-4621-86a7-a320df7aa65b"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                column: "GlobalId",
                value: new Guid("ec93e99c-28de-407d-aaeb-74d2e117ca0e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                column: "GlobalId",
                value: new Guid("6e7eb1a7-eb29-4e51-b0ff-bbb69f08f2e6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                column: "GlobalId",
                value: new Guid("db33b7f8-0da3-47ca-a97c-e1578d7b48a6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                column: "GlobalId",
                value: new Guid("02ff3024-8fce-46b9-bb03-6cbb9d6b113c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                column: "GlobalId",
                value: new Guid("e0b54897-739e-416d-bbb4-1960c71b419d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                column: "GlobalId",
                value: new Guid("57472c4c-9136-4b1b-ac6f-75fa1d682e9e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                column: "GlobalId",
                value: new Guid("265eca97-f744-49ec-bd75-74afefd81a73"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                column: "GlobalId",
                value: new Guid("db705165-9dc3-4cfc-a021-4bdc491254e1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                column: "GlobalId",
                value: new Guid("d318bd47-a2e2-4441-b81f-0857d764aca2"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                column: "GlobalId",
                value: new Guid("2a024ea7-e065-42db-bd7d-914ec2fe235e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                column: "GlobalId",
                value: new Guid("afded2ec-91d7-447a-9e91-4d90b1e31451"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                column: "GlobalId",
                value: new Guid("8e007ddd-794f-42f7-b208-a841d1fbd643"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                column: "GlobalId",
                value: new Guid("992ecc44-57a3-410f-99aa-554835ef2efe"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                column: "GlobalId",
                value: new Guid("993c0318-b1aa-4eb3-a7a1-2b9198f2c11d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                column: "GlobalId",
                value: new Guid("4baaeb82-f2b6-4f82-890a-27e387bd185c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                column: "GlobalId",
                value: new Guid("1d954f63-da95-4fcd-9be2-a39dcefb7eee"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                column: "GlobalId",
                value: new Guid("7653a232-788f-437e-b910-8d21701b0a06"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                column: "GlobalId",
                value: new Guid("0b04baa7-89df-44de-934f-6b0890431b71"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                column: "GlobalId",
                value: new Guid("7bdf0e8d-c953-43ec-85d1-c96850ee3d6e"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                column: "GlobalId",
                value: new Guid("f0e911e4-2ff8-40b8-abf4-13fbac6b85d3"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                column: "GlobalId",
                value: new Guid("c2fd40ee-1898-4ebd-ad37-58f5c950fe93"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                column: "GlobalId",
                value: new Guid("8155d363-0626-4480-8779-e8630da84ae1"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                column: "GlobalId",
                value: new Guid("fdc7c4db-492f-4c1b-ac52-2649121f5b88"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                column: "GlobalId",
                value: new Guid("3aca8322-b3f9-4311-8463-134df19af46f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                column: "GlobalId",
                value: new Guid("12887bfc-3b89-460f-8364-1afc4e6c920d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                column: "GlobalId",
                value: new Guid("8c5ece49-a7e0-47e6-b92d-c93e4694dad7"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                column: "GlobalId",
                value: new Guid("8eb118b7-f9f9-41f8-8270-8568fcdbb063"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                column: "GlobalId",
                value: new Guid("a59a2180-b1d3-4ecc-8699-32db2146bae6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                column: "GlobalId",
                value: new Guid("77c26af0-440d-4b75-8076-6afeb594e007"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                column: "GlobalId",
                value: new Guid("0acf348e-d1f1-4a4e-90a5-48ff1a777908"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                column: "GlobalId",
                value: new Guid("a5dbb070-3250-49a7-b37d-e34db2803b3f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                column: "GlobalId",
                value: new Guid("568a0bce-8a26-430b-9230-cc13d95a4934"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                column: "GlobalId",
                value: new Guid("691edd23-5945-4187-bdc0-b678f2fe6fee"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                column: "GlobalId",
                value: new Guid("3bf899d2-4654-4f3d-8880-78dda4861cf6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                column: "GlobalId",
                value: new Guid("9a446eb2-0337-471f-b850-1c25d098d674"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                column: "GlobalId",
                value: new Guid("bc41bb35-af55-4316-bb15-f815dc60da27"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                column: "GlobalId",
                value: new Guid("20a33e16-d124-46cc-9551-9930f49d0e91"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                column: "GlobalId",
                value: new Guid("da014a48-ec54-47dc-8f9a-76562e0fef36"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                column: "GlobalId",
                value: new Guid("d753bca7-6914-4f71-8bbb-603fe31e3652"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                column: "GlobalId",
                value: new Guid("dd3c5cd2-4ea5-4d9f-a3ae-b27ea7bb0c69"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                column: "GlobalId",
                value: new Guid("252f66bf-c121-4f8c-ae51-b19de4ba2c27"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                column: "GlobalId",
                value: new Guid("d48dc0a3-5059-4869-abaf-a79d516d1159"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                column: "GlobalId",
                value: new Guid("6834bdff-e902-417f-8579-d3c42a8f9f7c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                column: "GlobalId",
                value: new Guid("3703ba55-8d63-4932-a35b-3b8df668b89f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                column: "GlobalId",
                value: new Guid("c324b53f-4236-4489-8496-6eaf973ef4b9"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                column: "GlobalId",
                value: new Guid("9cad4aff-2b93-4a0c-8601-bde1c9b21f88"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                column: "GlobalId",
                value: new Guid("7c1e0e85-c86e-459d-9592-df04dfc563ff"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                column: "GlobalId",
                value: new Guid("cc7fbf22-0360-4e1a-9a7d-e5f4b1e30a11"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                column: "GlobalId",
                value: new Guid("d67c0148-9798-4cd3-8143-dcd47faa161c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                column: "GlobalId",
                value: new Guid("0cc0880f-a87a-42ea-afa7-30809203aadd"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                column: "GlobalId",
                value: new Guid("6a787aa8-7941-488c-b4f4-634ab7b520c6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                column: "GlobalId",
                value: new Guid("1fd5d5c2-6f05-4f6f-a2c8-636ab829384f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                column: "GlobalId",
                value: new Guid("7a67e39a-50f4-4736-83e6-038f98e16691"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                column: "GlobalId",
                value: new Guid("775ce1ba-d038-4bc3-b6ea-215a58e17d94"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                column: "GlobalId",
                value: new Guid("bfbe0d70-74f6-4fc3-a593-c822bafeac06"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                column: "GlobalId",
                value: new Guid("85aeada3-0f4b-4e7b-87d2-f3ac50c8fdf6"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                column: "GlobalId",
                value: new Guid("88f764d5-af32-4a93-84d9-15164dcfe3e3"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                column: "GlobalId",
                value: new Guid("424ed92b-ea7f-42e9-9d43-d51f38bb4bfb"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                column: "GlobalId",
                value: new Guid("b8d665b7-474a-44f1-a865-b3d1d9f97d15"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                column: "GlobalId",
                value: new Guid("1085aa2a-fae4-4928-a72a-ad991ef7ad49"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                column: "GlobalId",
                value: new Guid("10e5dd8d-1eec-4f61-bcdb-d8019cb3b9ff"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                column: "GlobalId",
                value: new Guid("dd48c006-a8bc-4a3e-9428-15e9c0b33a7f"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                column: "GlobalId",
                value: new Guid("4ed9a3d3-7dab-40e3-8733-3724b7d03d18"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                column: "GlobalId",
                value: new Guid("982252c5-d440-440e-950f-c35b20ec839d"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                column: "GlobalId",
                value: new Guid("306230a5-ebf1-4dad-b036-17a68a858b4c"));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                column: "GlobalId",
                value: new Guid("34b94cf6-0290-4f3f-a1c3-15175f8e1777"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("00cb981f-59c9-4c56-ad8c-0d0bf1c4f635"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("ba4375e7-7879-4dd8-b6d9-54d85bb0c1da"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("3f7304bd-e759-4016-882d-2a791ada27bc"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("d33c7421-b273-46f4-a68b-707c6a73a5b6"));
        }
    }
}
