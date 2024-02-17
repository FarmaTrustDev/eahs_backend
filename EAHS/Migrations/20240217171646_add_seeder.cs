using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EAHS.Migrations
{
    public partial class add_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, true, "+93", null, null, null, null, new Guid("1847ae5f-f65b-4c36-a77d-3308f7423e08"), "AF", "Afghanistan", null, null },
                    { 155, true, "+378", null, null, null, null, new Guid("e6897bec-e3a3-4ca4-91f6-dc7de308d7e6"), "SM", "San Marino", null, null },
                    { 156, true, "+966", null, null, null, null, new Guid("f8d99655-f225-4323-8e9d-e388871eb573"), "SA", "Saudi Arabia", null, null },
                    { 157, true, "+221", null, null, null, null, new Guid("4400eb87-539c-4612-9db0-e6812244cba6"), "SN", "Senegal", null, null },
                    { 158, true, "+381", null, null, null, null, new Guid("61af8eed-a98d-493c-aacc-6d21d13d20a7"), "RS", "Serbia", null, null },
                    { 159, true, "+248", null, null, null, null, new Guid("772aefb3-1fd8-4c8f-9ac0-49cfc689d2e5"), "SC", "Seychelles", null, null },
                    { 160, true, "+232", null, null, null, null, new Guid("556d0dcd-96db-45d4-9c40-70c135f50596"), "SL", "Sierra Leone", null, null },
                    { 161, true, "+65", null, null, null, null, new Guid("844cca2c-bc87-41c2-9685-9b5236f23572"), "SG", "Singapore", null, null },
                    { 162, true, "+421", null, null, null, null, new Guid("fa0fb65f-cfab-4c8b-a95b-a83c4a2f3860"), "SK", "Slovakia", null, null },
                    { 163, true, "+386", null, null, null, null, new Guid("6b75921f-6bab-4bb1-8dff-36db6fe80779"), "SI", "Slovenia", null, null },
                    { 164, true, "+677", null, null, null, null, new Guid("59b8015b-036b-47d9-badf-fd91cb11f456"), "SB", "Solomon Islands", null, null },
                    { 165, true, "+27", null, null, null, null, new Guid("8de97254-228b-4a6f-b5f7-39fe689d592b"), "ZA", "South Africa", null, null },
                    { 166, true, "+500", null, null, null, null, new Guid("c884840e-1838-4d66-8480-813a4be91b55"), "GS", "South Georgia and the South Sandwich Islands", null, null },
                    { 154, true, "+685", null, null, null, null, new Guid("95fb1f52-9d8b-4d0b-8860-c48246183c43"), "WS", "Samoa", null, null },
                    { 167, true, "+34", null, null, null, null, new Guid("ad725248-46d6-45ca-bf4c-ffbd1c4794df"), "ES", "Spain", null, null },
                    { 169, true, "+249", null, null, null, null, new Guid("c677a5b3-873f-4283-bc95-a3a6522009bc"), "SD", "Sudan", null, null },
                    { 170, true, "+597", null, null, null, null, new Guid("d471e136-2092-4ae4-ab6d-6a0ad8df3001"), "SR", "Suriname", null, null },
                    { 171, true, "+268", null, null, null, null, new Guid("0a35fd47-b1fa-432e-b8ae-c834a66fd758"), "SZ", "Swaziland", null, null },
                    { 172, true, "+46", null, null, null, null, new Guid("dcfc1981-cc91-41b2-a217-937c77879af2"), "SE", "Sweden", null, null },
                    { 173, true, "+41", null, null, null, null, new Guid("15f00989-ef50-477b-872c-ce667cd6d987"), "CH", "Switzerland", null, null },
                    { 174, true, "+992", null, null, null, null, new Guid("161b313a-d550-45da-9565-b10e8dc4950f"), "TJ", "Tajikistan", null, null },
                    { 175, true, "+66", null, null, null, null, new Guid("b3299978-d16c-4621-86a7-a320df7aa65b"), "TH", "Thailand", null, null },
                    { 176, true, "+228", null, null, null, null, new Guid("ec93e99c-28de-407d-aaeb-74d2e117ca0e"), "TG", "Togo", null, null },
                    { 177, true, "+690", null, null, null, null, new Guid("6e7eb1a7-eb29-4e51-b0ff-bbb69f08f2e6"), "TK", "Tokelau", null, null },
                    { 178, true, "+676", null, null, null, null, new Guid("db33b7f8-0da3-47ca-a97c-e1578d7b48a6"), "TO", "Tonga", null, null },
                    { 179, true, "+1 868", null, null, null, null, new Guid("02ff3024-8fce-46b9-bb03-6cbb9d6b113c"), "TT", "Trinidad and Tobago", null, null },
                    { 180, true, "+216", null, null, null, null, new Guid("e0b54897-739e-416d-bbb4-1960c71b419d"), "TN", "Tunisia", null, null },
                    { 168, true, "+94", null, null, null, null, new Guid("1a030bd1-69ab-4f27-849f-7e050437f5cd"), "LK", "Sri Lanka", null, null },
                    { 181, true, "+90", null, null, null, null, new Guid("57472c4c-9136-4b1b-ac6f-75fa1d682e9e"), "TR", "Turkey", null, null },
                    { 153, true, "+250", null, null, null, null, new Guid("81fc5970-f1fc-4ca2-9568-c6d5affd7385"), "RW", "Rwanda", null, null },
                    { 151, true, "+974", null, null, null, null, new Guid("1cc7b5e8-8e4e-4f90-8a31-7c684fc91707"), "QA", "Qatar", null, null },
                    { 125, true, "+95", null, null, null, null, new Guid("6371ced9-e968-48fc-966c-923b0bbcb32a"), "MM", "Myanmar", null, null },
                    { 126, true, "+264", null, null, null, null, new Guid("060500de-2a8e-4854-856d-e921acbab8c9"), "NA", "Namibia", null, null },
                    { 127, true, "+674", null, null, null, null, new Guid("96493380-e9dc-49fd-8ab5-f5098f231b3e"), "NR", "Nauru", null, null },
                    { 128, true, "+977", null, null, null, null, new Guid("4c23c5ab-07fd-4e1d-ba3c-1d27724bbff8"), "NP", "Nepal", null, null },
                    { 129, true, "+31", null, null, null, null, new Guid("0833ddea-dc8d-4675-a2e9-f6d3d5fd3a7d"), "NL", "Netherlands", null, null },
                    { 130, true, "+599", null, null, null, null, new Guid("a6bc31d8-b868-458c-bd99-496e4599ae14"), "AN", "Netherlands Antilles", null, null },
                    { 131, true, "+687", null, null, null, null, new Guid("980bf32f-bf2a-4608-9e31-d21e4e87f59d"), "NC", "New Caledonia", null, null },
                    { 132, true, "+64", null, null, null, null, new Guid("566c72eb-bb3a-4522-86db-3633a3f577ff"), "NZ", "New Zealand", null, null },
                    { 133, true, "+505", null, null, null, null, new Guid("d2a6fc37-8692-4977-bd66-8c0ef3095f51"), "NI", "Nicaragua", null, null },
                    { 134, true, "+227", null, null, null, null, new Guid("754fb50a-ac92-423a-b25a-acbc821930fd"), "NE", "Niger", null, null },
                    { 135, true, "+234", null, null, null, null, new Guid("34b9741e-729e-4f87-a87a-94c1a4672c56"), "NG", "Nigeria", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 136, true, "+683", null, null, null, null, new Guid("01a9f6a7-873e-465f-a097-f10db2cfba22"), "NU", "Niue", null, null },
                    { 152, true, "+40", null, null, null, null, new Guid("79348ba2-d2fb-4f8c-a0fd-3a6c3e57b5a2"), "RO", "Romania", null, null },
                    { 137, true, "+672", null, null, null, null, new Guid("64dbfbb0-7469-4d03-99c2-8cdbb9c13e37"), "NF", "Norfolk Island", null, null },
                    { 139, true, "+47", null, null, null, null, new Guid("f5f6efe3-02db-4cfc-be33-16e9a0e328e4"), "NO", "Norway", null, null },
                    { 140, true, "+968", null, null, null, null, new Guid("bc33c6d1-280b-4f1a-a845-c32aa6d8e478"), "OM", "Oman", null, null },
                    { 141, true, "+92", null, null, null, null, new Guid("90248c46-608a-44f2-ad91-82fb25cffd17"), "PK", "Pakistan", null, null },
                    { 142, true, "+680", null, null, null, null, new Guid("951d7723-67a7-41af-82b1-e5d8edaf9b6d"), "PW", "Palau", null, null },
                    { 143, true, "+507", null, null, null, null, new Guid("063600fa-7083-493d-981d-ab6c54ba1f24"), "PA", "Panama", null, null },
                    { 144, true, "+675", null, null, null, null, new Guid("d3b383e5-308b-4205-b750-d12840d069e3"), "PG", "Papua New Guinea", null, null },
                    { 145, true, "+595", null, null, null, null, new Guid("55e90e88-c102-4446-8be8-d521742cf33d"), "PY", "Paraguay", null, null },
                    { 146, true, "+51", null, null, null, null, new Guid("957464d0-ed0f-4a3a-9308-6c7c463dbe44"), "PE", "Peru", null, null },
                    { 147, true, "+63", null, null, null, null, new Guid("d85e332a-ba40-4505-8a01-8dcad84bfac0"), "PH", "Philippines", null, null },
                    { 148, true, "+48", null, null, null, null, new Guid("f845a76c-0235-4bc1-996c-3711633bf011"), "PL", "Poland", null, null },
                    { 149, true, "+351", null, null, null, null, new Guid("b579c7e2-7fae-484b-8e4b-d5c34d6cf133"), "PT", "Portugal", null, null },
                    { 150, true, "+1 939", null, null, null, null, new Guid("bda05b70-58c6-47be-accd-280bca0c7170"), "PR", "Puerto Rico", null, null },
                    { 138, true, "+1 670", null, null, null, null, new Guid("66d5873f-9834-4b32-af5d-9ad235a5b1a2"), "MP", "Northern Mariana Islands", null, null },
                    { 182, true, "+993", null, null, null, null, new Guid("265eca97-f744-49ec-bd75-74afefd81a73"), "TM", "Turkmenistan", null, null },
                    { 183, true, "+1 649", null, null, null, null, new Guid("db705165-9dc3-4cfc-a021-4bdc491254e1"), "TC", "Turks and Caicos Islands", null, null },
                    { 184, true, "+688", null, null, null, null, new Guid("d318bd47-a2e2-4441-b81f-0857d764aca2"), "TV", "Tuvalu", null, null },
                    { 216, true, "+389", null, null, null, null, new Guid("252f66bf-c121-4f8c-ae51-b19de4ba2c27"), "MK", "Macedonia, The Former Yugoslav Republic of", null, null },
                    { 217, true, "+691", null, null, null, null, new Guid("d48dc0a3-5059-4869-abaf-a79d516d1159"), "FM", "Micronesia, Federated States of", null, null },
                    { 218, true, "+373", null, null, null, null, new Guid("6834bdff-e902-417f-8579-d3c42a8f9f7c"), "MD", "Moldova, Republic of", null, null },
                    { 219, true, "+258", null, null, null, null, new Guid("3703ba55-8d63-4932-a35b-3b8df668b89f"), "MZ", "Mozambique", null, null },
                    { 220, true, "+970", null, null, null, null, new Guid("c324b53f-4236-4489-8496-6eaf973ef4b9"), "PS", "Palestinian Territory, Occupied", null, null },
                    { 221, true, "+872", null, null, null, null, new Guid("9cad4aff-2b93-4a0c-8601-bde1c9b21f88"), "PN", "Pitcairn", null, null },
                    { 222, true, "+262", null, null, null, null, new Guid("7c1e0e85-c86e-459d-9592-df04dfc563ff"), "RE", "Reunion", null, null },
                    { 223, true, "+7", null, null, null, null, new Guid("cc7fbf22-0360-4e1a-9a7d-e5f4b1e30a11"), "RU", "Russia", null, null },
                    { 224, true, "+590", null, null, null, null, new Guid("d67c0148-9798-4cd3-8143-dcd47faa161c"), "BL", "Saint Barthelemy", null, null },
                    { 225, true, "+290", null, null, null, null, new Guid("0cc0880f-a87a-42ea-afa7-30809203aadd"), "SH", "Saint Helena, Ascension and Tristan Da Cunha", null, null },
                    { 226, true, "+1 869", null, null, null, null, new Guid("6a787aa8-7941-488c-b4f4-634ab7b520c6"), "KN", "Saint Kitts and Nevis", null, null },
                    { 227, true, "+1 758", null, null, null, null, new Guid("1fd5d5c2-6f05-4f6f-a2c8-636ab829384f"), "LC", "Saint Lucia", null, null },
                    { 215, true, "+853", null, null, null, null, new Guid("dd3c5cd2-4ea5-4d9f-a3ae-b27ea7bb0c69"), "MO", "Macao", null, null },
                    { 228, true, "+590", null, null, null, null, new Guid("7a67e39a-50f4-4736-83e6-038f98e16691"), "MF", "Saint Martin", null, null },
                    { 230, true, "+1 784", null, null, null, null, new Guid("bfbe0d70-74f6-4fc3-a593-c822bafeac06"), "VC", "Saint Vincent and the Grenadines", null, null },
                    { 231, true, "+239", null, null, null, null, new Guid("85aeada3-0f4b-4e7b-87d2-f3ac50c8fdf6"), "ST", "Sao Tome and Principe", null, null },
                    { 232, true, "+252", null, null, null, null, new Guid("88f764d5-af32-4a93-84d9-15164dcfe3e3"), "SO", "Somalia", null, null },
                    { 233, true, "+47", null, null, null, null, new Guid("424ed92b-ea7f-42e9-9d43-d51f38bb4bfb"), "SJ", "Svalbard and Jan Mayen", null, null },
                    { 234, true, "+963", null, null, null, null, new Guid("b8d665b7-474a-44f1-a865-b3d1d9f97d15"), "SY", "Syrian Arab Republic", null, null },
                    { 235, true, "+886", null, null, null, null, new Guid("1085aa2a-fae4-4928-a72a-ad991ef7ad49"), "TW", "Taiwan, Province of China", null, null },
                    { 236, true, "+255", null, null, null, null, new Guid("10e5dd8d-1eec-4f61-bcdb-d8019cb3b9ff"), "TZ", "Tanzania, United Republic of", null, null },
                    { 237, true, "+670", null, null, null, null, new Guid("dd48c006-a8bc-4a3e-9428-15e9c0b33a7f"), "TL", "Timor-Leste", null, null },
                    { 238, true, "+58", null, null, null, null, new Guid("4ed9a3d3-7dab-40e3-8733-3724b7d03d18"), "VE", "Venezuela, Bolivarian Republic of", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 239, true, "+84", null, null, null, null, new Guid("982252c5-d440-440e-950f-c35b20ec839d"), "VN", "Viet Nam", null, null },
                    { 240, true, "+1 284", null, null, null, null, new Guid("306230a5-ebf1-4dad-b036-17a68a858b4c"), "VG", "Virgin Islands, British", null, null },
                    { 241, true, "+1 340", null, null, null, null, new Guid("34b94cf6-0290-4f3f-a1c3-15175f8e1777"), "VI", "Virgin Islands, U.S.", null, null },
                    { 229, true, "+508", null, null, null, null, new Guid("775ce1ba-d038-4bc3-b6ea-215a58e17d94"), "PM", "Saint Pierre and Miquelon", null, null },
                    { 214, true, "+218", null, null, null, null, new Guid("d753bca7-6914-4f71-8bbb-603fe31e3652"), "LY", "Libyan Arab Jamahiriya", null, null },
                    { 213, true, "+856", null, null, null, null, new Guid("da014a48-ec54-47dc-8f9a-76562e0fef36"), "LA", "Lao People's Democratic Republic", null, null },
                    { 212, true, "+82", null, null, null, null, new Guid("20a33e16-d124-46cc-9551-9930f49d0e91"), "KR", "Korea, Republic of", null, null },
                    { 185, true, "+256", null, null, null, null, new Guid("2a024ea7-e065-42db-bd7d-914ec2fe235e"), "UG", "Uganda", null, null },
                    { 186, true, "+380", null, null, null, null, new Guid("afded2ec-91d7-447a-9e91-4d90b1e31451"), "UA", "Ukraine", null, null },
                    { 187, true, "+971", null, null, null, null, new Guid("8e007ddd-794f-42f7-b208-a841d1fbd643"), "AE", "United Arab Emirates", null, null },
                    { 188, true, "+44", null, null, null, null, new Guid("992ecc44-57a3-410f-99aa-554835ef2efe"), "GB", "United Kingdom", null, null },
                    { 189, true, "+1", null, null, null, null, new Guid("993c0318-b1aa-4eb3-a7a1-2b9198f2c11d"), "US", "United States", null, null },
                    { 190, true, "+598", null, null, null, null, new Guid("4baaeb82-f2b6-4f82-890a-27e387bd185c"), "UY", "Uruguay", null, null },
                    { 191, true, "+998", null, null, null, null, new Guid("1d954f63-da95-4fcd-9be2-a39dcefb7eee"), "UZ", "Uzbekistan", null, null },
                    { 192, true, "+678", null, null, null, null, new Guid("7653a232-788f-437e-b910-8d21701b0a06"), "VU", "Vanuatu", null, null },
                    { 193, true, "+681", null, null, null, null, new Guid("0b04baa7-89df-44de-934f-6b0890431b71"), "WF", "Wallis and Futuna", null, null },
                    { 194, true, "+967", null, null, null, null, new Guid("7bdf0e8d-c953-43ec-85d1-c96850ee3d6e"), "YE", "Yemen", null, null },
                    { 195, true, "+260", null, null, null, null, new Guid("f0e911e4-2ff8-40b8-abf4-13fbac6b85d3"), "ZM", "Zambia", null, null },
                    { 196, true, "+263", null, null, null, null, new Guid("c2fd40ee-1898-4ebd-ad37-58f5c950fe93"), "ZW", "Zimbabwe", null, null },
                    { 197, true, "", null, null, null, null, new Guid("8155d363-0626-4480-8779-e8630da84ae1"), "AX", "land Islands", null, null },
                    { 198, true, null, null, null, null, null, new Guid("fdc7c4db-492f-4c1b-ac52-2649121f5b88"), "AQ", "Antarctica", null, null },
                    { 199, true, "+591", null, null, null, null, new Guid("3aca8322-b3f9-4311-8463-134df19af46f"), "BO", "Bolivia, Plurinational State of", null, null },
                    { 200, true, "+673", null, null, null, null, new Guid("12887bfc-3b89-460f-8364-1afc4e6c920d"), "BN", "Brunei Darussalam", null, null },
                    { 201, true, "+61", null, null, null, null, new Guid("8c5ece49-a7e0-47e6-b92d-c93e4694dad7"), "CC", "Cocos (Keeling) Islands", null, null },
                    { 202, true, "+243", null, null, null, null, new Guid("8eb118b7-f9f9-41f8-8270-8568fcdbb063"), "CD", "Congo, The Democratic Republic of the", null, null },
                    { 203, true, "+225", null, null, null, null, new Guid("a59a2180-b1d3-4ecc-8699-32db2146bae6"), "CI", "Cote d'Ivoire", null, null },
                    { 204, true, "+500", null, null, null, null, new Guid("77c26af0-440d-4b75-8076-6afeb594e007"), "FK", "Falkland Islands (Malvinas)", null, null },
                    { 205, true, "+44", null, null, null, null, new Guid("0acf348e-d1f1-4a4e-90a5-48ff1a777908"), "GG", "Guernsey", null, null },
                    { 206, true, "+379", null, null, null, null, new Guid("a5dbb070-3250-49a7-b37d-e34db2803b3f"), "VA", "Holy See (Vatican City State)", null, null },
                    { 207, true, "+852", null, null, null, null, new Guid("568a0bce-8a26-430b-9230-cc13d95a4934"), "HK", "Hong Kong", null, null },
                    { 208, true, "+98", null, null, null, null, new Guid("691edd23-5945-4187-bdc0-b678f2fe6fee"), "IR", "Iran, Islamic Republic of", null, null },
                    { 209, true, "+44", null, null, null, null, new Guid("3bf899d2-4654-4f3d-8880-78dda4861cf6"), "IM", "Isle of Man", null, null },
                    { 210, true, "+44", null, null, null, null, new Guid("9a446eb2-0337-471f-b850-1c25d098d674"), "JE", "Jersey", null, null },
                    { 211, true, "+850", null, null, null, null, new Guid("bc41bb35-af55-4316-bb15-f815dc60da27"), "KP", "Korea, Democratic People's Republic of", null, null },
                    { 124, true, "+212", null, null, null, null, new Guid("7ac6bf23-a3f7-447d-afaf-b79f7296c8ae"), "MA", "Morocco", null, null },
                    { 122, true, "+382", null, null, null, null, new Guid("ab379982-8fca-4512-b680-92ff23467f2f"), "ME", "Montenegro", null, null },
                    { 123, true, "+1664", null, null, null, null, new Guid("e0b3f1c0-f2fa-44a4-a584-8d4c354ec13d"), "MS", "Montserrat", null, null },
                    { 120, true, "+377", null, null, null, null, new Guid("bc102601-f030-4b6d-829c-71364e2bf4a1"), "MC", "Monaco", null, null },
                    { 33, true, "+237", null, null, null, null, new Guid("ed908bd0-49fd-457d-b53f-2f0b4222f2ba"), "CM", "Cameroon", null, null },
                    { 34, true, "+1", null, null, null, null, new Guid("294218f3-d923-41d8-a7cd-778cf65d5ea8"), "CA", "Canada", null, null },
                    { 35, true, "+238", null, null, null, null, new Guid("13226658-a5d6-4312-bf25-0f6eb9108648"), "CV", "Cape Verde", null, null },
                    { 36, true, "+ 345", null, null, null, null, new Guid("c1ef7e27-5b98-4487-9836-d684c97b34d4"), "KY", "Cayman Islands", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 37, true, "+236", null, null, null, null, new Guid("9b58b043-6c59-41ed-af30-fc1abfea7758"), "CF", "Central African Republic", null, null },
                    { 38, true, "+235", null, null, null, null, new Guid("af1ea620-6171-497e-8089-a2a845b8d69d"), "TD", "Chad", null, null },
                    { 39, true, "+56", null, null, null, null, new Guid("d9720465-201f-48e1-8bd7-7200bb5eaeac"), "CL", "Chile", null, null },
                    { 40, true, "+86", null, null, null, null, new Guid("5f932489-3336-4878-9e59-49e1baa0a220"), "CN", "China", null, null },
                    { 41, true, "+61", null, null, null, null, new Guid("66fcca85-69ce-4c26-bdff-af5aca02161c"), "CX", "Christmas Island", null, null },
                    { 42, true, "+57", null, null, null, null, new Guid("116193d5-77af-4305-a2a7-5ce2c28a1cf9"), "CO", "Colombia", null, null },
                    { 43, true, "+269", null, null, null, null, new Guid("be4fe77b-eee4-4781-8790-dc0f33095424"), "KM", "Comoros", null, null },
                    { 44, true, "+242", null, null, null, null, new Guid("6e7613fb-f5d2-4f90-8db0-3cd4b6710592"), "CG", "Congo", null, null },
                    { 32, true, "+855", null, null, null, null, new Guid("907cd74f-7e3b-4415-9561-ec43554a6b7a"), "KH", "Cambodia", null, null },
                    { 45, true, "+682", null, null, null, null, new Guid("39ef9dac-b1a8-4a8c-a145-c1e05af544ac"), "CK", "Cook Islands", null, null },
                    { 47, true, "+385", null, null, null, null, new Guid("2c544fb7-8c36-456c-9b98-181f5af4be2a"), "HR", "Croatia", null, null },
                    { 48, true, "+53", null, null, null, null, new Guid("ef56e227-b31b-47ec-9195-cc96edf04891"), "CU", "Cuba", null, null },
                    { 49, true, "+537", null, null, null, null, new Guid("61db4c32-6eb2-4d06-b5df-86e012ba5c93"), "CY", "Cyprus", null, null },
                    { 50, true, "+420", null, null, null, null, new Guid("a401a9fc-1b6f-4ecb-b7ac-d87e6fe90592"), "CZ", "Czech Republic", null, null },
                    { 51, true, "+45", null, null, null, null, new Guid("968a2ca1-3f32-43fd-a46b-6490797be462"), "DK", "Denmark", null, null },
                    { 52, true, "+253", null, null, null, null, new Guid("4f5b18df-963f-47e0-b28a-8c799a8f45f1"), "DJ", "Djibouti", null, null },
                    { 53, true, "+1 767", null, null, null, null, new Guid("1a8b2178-69f3-43ad-8f15-178f472d49e0"), "DM", "Dominica", null, null },
                    { 54, true, "+1 849", null, null, null, null, new Guid("3b4f14a5-ad28-4b0a-8661-c652fbed84e4"), "DO", "Dominican Republic", null, null },
                    { 55, true, "+593", null, null, null, null, new Guid("7e702a1a-4366-4ab9-a09e-86f917dd4fb1"), "EC", "Ecuador", null, null },
                    { 56, true, "+20", null, null, null, null, new Guid("55363b86-3513-4d5a-bf92-e71f05d6eb14"), "EG", "Egypt", null, null },
                    { 57, true, "+503", null, null, null, null, new Guid("a9b94765-948f-44cd-85b4-f2df34a3ae2c"), "SV", "El Salvador", null, null },
                    { 58, true, "+240", null, null, null, null, new Guid("12e04153-4b07-4a92-86d2-160a607c8559"), "GQ", "Equatorial Guinea", null, null },
                    { 46, true, "+506", null, null, null, null, new Guid("fe92d264-7045-479a-89a8-1a6bdb744f79"), "CR", "Costa Rica", null, null },
                    { 31, true, "+257", null, null, null, null, new Guid("e19e6119-dfa6-4741-85b7-b44d6bcd829d"), "BI", "Burundi", null, null },
                    { 30, true, "+226", null, null, null, null, new Guid("bf3fbed2-3a31-496e-97ee-49526fc7a91e"), "BF", "Burkina Faso", null, null },
                    { 29, true, "+359", null, null, null, null, new Guid("69d36062-1e47-4e41-8c36-2de6a7d13938"), "BG", "Bulgaria", null, null },
                    { 2, true, "+355", null, null, null, null, new Guid("767a7fe7-3047-4f8f-ae3c-6e68834dacf5"), "AL", "Albania", null, null },
                    { 3, true, "+213", null, null, null, null, new Guid("af69355e-033a-41f6-a869-316dbc75438d"), "DZ", "Algeria", null, null },
                    { 4, true, "+1 684", null, null, null, null, new Guid("deb26b5c-0220-43e8-b84d-35877da844a6"), "AS", "AmericanSamoa", null, null },
                    { 5, true, "+376", null, null, null, null, new Guid("6932c35c-ac93-4f41-ba30-dfee6324ae0f"), "AD", "Andorra", null, null },
                    { 6, true, "+244", null, null, null, null, new Guid("e26b9044-50f6-4434-a661-e04150ecc007"), "AO", "Angola", null, null },
                    { 7, true, "+1 264", null, null, null, null, new Guid("f1696438-5364-4795-aaa5-de63af853fa9"), "AI", "Anguilla", null, null },
                    { 8, true, "+1268", null, null, null, null, new Guid("7d8df3dc-fe40-4bfd-8229-3b2e2c51e2d0"), "AG", "Antigua and Barbuda", null, null },
                    { 9, true, "+54", null, null, null, null, new Guid("a78d0596-a101-4d05-8907-104a74c07e9c"), "AR", "Argentina", null, null },
                    { 10, true, "+374", null, null, null, null, new Guid("000955f2-e5a0-442d-9c23-fdbca161d626"), "AM", "Armenia", null, null },
                    { 11, true, "+297", null, null, null, null, new Guid("3a644807-04da-4a40-94cc-a4ad89565f36"), "AW", "Aruba", null, null },
                    { 12, true, "+61", null, null, null, null, new Guid("0b4ebfb0-0852-40d9-8108-b48936228e57"), "AU", "Australia", null, null },
                    { 13, true, "+43", null, null, null, null, new Guid("be2d86e8-474c-457c-bd5c-ab77aa379abe"), "AT", "Austria", null, null },
                    { 14, true, "+994", null, null, null, null, new Guid("f722718c-5ea8-4730-91e0-48fe0d2fbacc"), "AZ", "Azerbaijan", null, null },
                    { 15, true, "+1 242", null, null, null, null, new Guid("9ac3fcd8-9cff-4e0e-aa9c-ee096a08213e"), "BS", "Bahamas", null, null },
                    { 16, true, "+973", null, null, null, null, new Guid("c9d9fa51-0433-4663-a62c-f55eb97d3c91"), "BH", "Bahrain", null, null },
                    { 17, true, "+880", null, null, null, null, new Guid("bc993713-9ce3-4711-9f27-031e658f4618"), "BD", "Bangladesh", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 18, true, "+1 246", null, null, null, null, new Guid("964cf17d-1253-44d2-b3e7-8ed1ad142554"), "BB", "Barbados", null, null },
                    { 19, true, "+375", null, null, null, null, new Guid("24166191-01d0-4a1c-a7dc-500ba4a0448e"), "BY", "Belarus", null, null },
                    { 20, true, "+32", null, null, null, null, new Guid("7fe3eb94-b570-43ae-bff8-d226556c0335"), "BE", "Belgium", null, null },
                    { 21, true, "+501", null, null, null, null, new Guid("56820a6e-afcc-4dce-bdd0-dbae465ce415"), "BZ", "Belize", null, null },
                    { 22, true, "+229", null, null, null, null, new Guid("30b82a04-af95-4a30-9c9c-e6758bd282f2"), "BJ", "Benin", null, null },
                    { 23, true, "+1 441", null, null, null, null, new Guid("abea5400-7d57-43c2-ac1c-df844c5b8e3b"), "BM", "Bermuda", null, null },
                    { 24, true, "+975", null, null, null, null, new Guid("8566f4b0-37a6-4df9-adb4-8832e5baec05"), "BT", "Bhutan", null, null },
                    { 25, true, "+387", null, null, null, null, new Guid("9a5ff34f-3f72-4bef-933a-0b054b33a8e0"), "BA", "Bosnia and Herzegovina", null, null },
                    { 26, true, "+267", null, null, null, null, new Guid("1bc7d11a-7c08-4016-80e3-58fc69387a4f"), "BW", "Botswana", null, null },
                    { 27, true, "+55", null, null, null, null, new Guid("0ee178df-5026-4a3c-b1f8-32e52c4be80e"), "BR", "Brazil", null, null },
                    { 28, true, "+246", null, null, null, null, new Guid("404ecfb8-e1bd-4345-b32c-3d03dc12d9a7"), "IO", "British Indian Ocean Territory", null, null },
                    { 59, true, "+291", null, null, null, null, new Guid("cccfd174-de78-4a96-b40f-8bf801446623"), "ER", "Eritrea", null, null },
                    { 121, true, "+976", null, null, null, null, new Guid("03a50435-30c5-4cc6-9d5b-8e94c7a9f846"), "MN", "Mongolia", null, null },
                    { 60, true, "+372", null, null, null, null, new Guid("5a43b5e8-2f5d-42d4-9947-314a0a4a5562"), "EE", "Estonia", null, null },
                    { 62, true, "+298", null, null, null, null, new Guid("3fd99002-597b-4aa4-af41-58b5d8ab4136"), "FO", "Faroe Islands", null, null },
                    { 94, true, "+81", null, null, null, null, new Guid("a1c1a1f8-f486-48e0-b995-468aeec8125b"), "JP", "Japan", null, null },
                    { 95, true, "+962", null, null, null, null, new Guid("3967dbb2-278d-4356-948e-61bcd61dfd79"), "JO", "Jordan", null, null },
                    { 96, true, "+7 7", null, null, null, null, new Guid("0e7f47e5-3d1f-4f98-b154-a6adcd2c4688"), "KZ", "Kazakhstan", null, null },
                    { 97, true, "+254", null, null, null, null, new Guid("ebd926b9-1468-4de2-bc55-29cd7fb9cdfb"), "KE", "Kenya", null, null },
                    { 98, true, "+686", null, null, null, null, new Guid("8e99462e-5b25-414c-ad32-08753c668b74"), "KI", "Kiribati", null, null },
                    { 99, true, "+965", null, null, null, null, new Guid("e42e4497-da5d-41c8-b7e7-ea305d68beeb"), "KW", "Kuwait", null, null },
                    { 100, true, "+996", null, null, null, null, new Guid("62b2905b-2cfb-404a-b3ac-92bbfa343be4"), "KG", "Kyrgyzstan", null, null },
                    { 101, true, "+371", null, null, null, null, new Guid("7934120b-4ab6-49e0-a795-25753fea3f74"), "LV", "Latvia", null, null },
                    { 102, true, "+961", null, null, null, null, new Guid("3c7193f6-bed7-456e-b2f6-bd0903ef2791"), "LB", "Lebanon", null, null },
                    { 103, true, "+266", null, null, null, null, new Guid("66e05eec-4f14-4c5e-a00a-05e309b575a6"), "LS", "Lesotho", null, null },
                    { 104, true, "+231", null, null, null, null, new Guid("448e5ba9-f229-4fc3-9b6c-0f96056f8340"), "LR", "Liberia", null, null },
                    { 105, true, "+423", null, null, null, null, new Guid("5177c0c8-b43d-4d57-9db2-c1ab728b4a4c"), "LI", "Liechtenstein", null, null },
                    { 61, true, "+251", null, null, null, null, new Guid("648e1ebb-5429-4888-a772-6b25c140d271"), "ET", "Ethiopia", null, null },
                    { 106, true, "+370", null, null, null, null, new Guid("695aa828-7d5a-42e4-b8f5-328895c71fef"), "LT", "Lithuania", null, null },
                    { 108, true, "+261", null, null, null, null, new Guid("5aab874d-781f-4fb6-9a60-132341ed078d"), "MG", "Madagascar", null, null },
                    { 109, true, "+265", null, null, null, null, new Guid("37b56ac5-922d-43b9-890d-dde93d6f364f"), "MW", "Malawi", null, null },
                    { 110, true, "+60", null, null, null, null, new Guid("debb4629-3152-4a20-be57-b992ef5247ec"), "MY", "Malaysia", null, null },
                    { 111, true, "+960", null, null, null, null, new Guid("250602bd-a7dd-4e42-8edc-762009b84a9d"), "MV", "Maldives", null, null },
                    { 112, true, "+223", null, null, null, null, new Guid("00229bf7-eb1b-4bd5-8526-77449bf65bfb"), "ML", "Mali", null, null },
                    { 113, true, "+356", null, null, null, null, new Guid("be185f0e-2eab-40d2-9880-6920f32f9247"), "MT", "Malta", null, null },
                    { 114, true, "+692", null, null, null, null, new Guid("62852080-74e4-489c-864b-b3ac79865d7f"), "MH", "Marshall Islands", null, null },
                    { 115, true, "+596", null, null, null, null, new Guid("59048f87-4611-49d6-9636-510a558fa895"), "MQ", "Martinique", null, null },
                    { 116, true, "+222", null, null, null, null, new Guid("3c725d9e-18bf-4f0c-8a1d-3b3762ce6f73"), "MR", "Mauritania", null, null },
                    { 117, true, "+230", null, null, null, null, new Guid("6fa91046-c270-4eb5-af56-e1191d0c5030"), "MU", "Mauritius", null, null },
                    { 118, true, "+262", null, null, null, null, new Guid("34b3c822-0d86-495d-a74e-cd22fd44af7f"), "YT", "Mayotte", null, null },
                    { 119, true, "+52", null, null, null, null, new Guid("ff3cc667-39c5-426b-a2d6-6235edd91b09"), "MX", "Mexico", null, null },
                    { 107, true, "+352", null, null, null, null, new Guid("1ddd86b8-1034-4b2f-96c3-a4c571bac8dc"), "LU", "Luxembourg", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Active", "CountryCode", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "GlobalId", "ISO", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 92, true, "+39", null, null, null, null, new Guid("5ebdf45d-24c3-4f62-a092-f18ea1ff057c"), "IT", "Italy", null, null },
                    { 93, true, "+1 876", null, null, null, null, new Guid("e4cd6d79-dd8b-4100-b64a-798de328253d"), "JM", "Jamaica", null, null },
                    { 90, true, "+353", null, null, null, null, new Guid("e94bbf6e-3d9a-4dc6-bffa-a8be94aad771"), "IE", "Ireland", null, null },
                    { 63, true, "+679", null, null, null, null, new Guid("2251f920-556c-43c1-817f-dec42bdf4dac"), "FJ", "Fiji", null, null },
                    { 64, true, "+358", null, null, null, null, new Guid("ef54e9b1-74ff-44c6-af0d-06eb9b27baf4"), "FI", "Finland", null, null },
                    { 65, true, "+33", null, null, null, null, new Guid("c03addd4-7f6d-4f36-a77c-c737f7bd8b8d"), "FR", "France", null, null },
                    { 66, true, "+594", null, null, null, null, new Guid("900368c0-67df-4b8d-bbac-0ac88f6a8ef2"), "GF", "French Guiana", null, null },
                    { 67, true, "+689", null, null, null, null, new Guid("debb42ab-2bf9-40e3-9625-b5510ba93bd9"), "PF", "French Polynesia", null, null },
                    { 68, true, "+241", null, null, null, null, new Guid("3b0fc979-668c-4ea2-8b0d-bdd0f30648b5"), "GA", "Gabon", null, null },
                    { 69, true, "+220", null, null, null, null, new Guid("308761eb-e273-453d-9f12-5e01faf65dbf"), "GM", "Gambia", null, null },
                    { 70, true, "+995", null, null, null, null, new Guid("0eedcafe-e7e8-4b51-bfed-16aebfa5b3a5"), "GE", "Georgia", null, null },
                    { 71, true, "+49", null, null, null, null, new Guid("37ee9d07-c344-457f-8613-d1e1c7e073b7"), "DE", "Germany", null, null },
                    { 72, true, "+233", null, null, null, null, new Guid("a2d452f7-85b8-49b4-9eda-acd8caf8e720"), "GH", "Ghana", null, null },
                    { 73, true, "+350", null, null, null, null, new Guid("16be8b5d-1ad8-417d-a0d7-649729c05819"), "GI", "Gibraltar", null, null },
                    { 91, true, "+972", null, null, null, null, new Guid("56679e39-5f25-4f1e-84db-2d0178c7bbe3"), "IL", "Israel", null, null },
                    { 75, true, "+299", null, null, null, null, new Guid("283770c8-5a40-42be-94ac-632bba6caeae"), "GL", "Greenland", null, null },
                    { 74, true, "+30", null, null, null, null, new Guid("6973dc6d-e68d-4c2b-a86c-d78bea2f337c"), "GR", "Greece", null, null },
                    { 77, true, "+590", null, null, null, null, new Guid("a0634a56-4353-45a7-892f-6d9f7803e863"), "GP", "Guadeloupe", null, null },
                    { 89, true, "+964", null, null, null, null, new Guid("0800ee88-ff0f-4a42-9c8c-b7c9dc87e7ea"), "IQ", "Iraq", null, null },
                    { 88, true, "+62", null, null, null, null, new Guid("00527757-12d0-48e5-9512-d1e747f38051"), "ID", "Indonesia", null, null },
                    { 87, true, "+91", null, null, null, null, new Guid("7cd6b2a3-0f4a-49f5-8fb3-be67d9177d43"), "IN", "India", null, null },
                    { 86, true, "+354", null, null, null, null, new Guid("4a798502-2971-49ea-8404-4e3aa6778d82"), "IS", "Iceland", null, null },
                    { 76, true, "+1 473", null, null, null, null, new Guid("dec707bf-1047-406a-b82a-795a462d6440"), "GD", "Grenada", null, null },
                    { 84, true, "+504", null, null, null, null, new Guid("ea613499-120a-423c-be54-47dabcfbcbe1"), "HN", "Honduras", null, null },
                    { 85, true, "+36", null, null, null, null, new Guid("b4b3fa91-38cd-423f-9b3f-ebc8114de116"), "HU", "Hungary", null, null },
                    { 82, true, "+595", null, null, null, null, new Guid("09c20e32-9568-4c36-8087-a91d72f2f70a"), "GY", "Guyana", null, null },
                    { 81, true, "+245", null, null, null, null, new Guid("5b58e117-5288-4df4-aa01-4dce4f6b9435"), "GW", "Guinea-Bissau", null, null },
                    { 80, true, "+224", null, null, null, null, new Guid("85df91e2-99a6-4a3f-8e15-fef0565b9395"), "GN", "Guinea", null, null },
                    { 79, true, "+502", null, null, null, null, new Guid("d571ee60-d384-45fc-ab2b-e8432229e390"), "GT", "Guatemala", null, null },
                    { 78, true, "+1 671", null, null, null, null, new Guid("14a60552-6916-44d0-82d4-1e570f238c8d"), "GU", "Guam", null, null },
                    { 83, true, "+509", null, null, null, null, new Guid("c450827b-4020-46ba-9a7b-6824599e6e0a"), "HT", "Haiti", null, null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("4568ef31-6ce4-48ee-9e89-d93f590c80be"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("aff395a3-0c9f-4762-82bf-6aef40b7d0b3"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("68848752-7c7a-4171-ae45-a32da6a8d2f1"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("e50a97c8-f8fd-4f7e-8f7d-b85b48dc094c"));
        }
    }
}
