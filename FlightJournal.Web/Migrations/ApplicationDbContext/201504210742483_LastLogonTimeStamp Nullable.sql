﻿ALTER TABLE [dbo].[AspNetUsers] ALTER COLUMN [LastLogonTimeStamp] [datetime] NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201504210742483_LastLogonTimeStamp Nullable', N'FlightJournal.Web.Migrations.ApplicationDbContext.Configuration',  0x1F8B0800000000000400DD5C596FE436127E5F60FF83A0A7DD85D3F2B1339818DD093C6D77D6BBBE30ED49F66DC096D86D6124529128C746905F9687FCA4FD0B5BD42D1E3ABAD5878301063659FCAA58AC228BA5A2FFF7FB1FE3EF5F7CCF78C661E45232314F46C7A681894D1D97AC2666CC96DF7C30BFFFEEAF7F195F39FE8BF1634E77C6E960248926E61363C1B96545F613F65134F25D3BA4115DB2914D7D0B39D43A3D3EFED63A39B1304098806518E34F3161AE8F935FE0D72925360E588CBC5BEA602FCADAA1679EA01A77C8C751806C3C31679EBB7A62FFA671489037FA092F46E918D3B8F05C04F2CCB1B7340D4408658881B4E79F233C672125AB79000DC87B7C0D30D02D9117E16C16E72579D7091D9FF20959E5C01CCA8E2346FD9E80276799862C71F85A7A360B0D820EAF40D7EC95CF3AD1E3C4BC7670D2F4897AA00091E1F9D40B39F1C4BC2D585C44C11D66A37CE028859C8500F70B0DBF8EAA884746E7714785459D8E8EF9BF23631A7B2C0EF184E09885C83B321EE285E7DAFFC1AF8FF42B2693B393C5F2ECC3BBF7C8397BFF4F7CF6AE3A53982BD0D51AA0E921A4010E4136BC2CE66F1A567D9C250E2C8655C6A45A015B02E7308D5BF47283C98A3D81DB9C7E308D99FB829DBC2533AECFC4055F82412C8CE1D7BBD8F3D0C2C345BFD5C893FFDFC0F5F4DDFB41B8DEA16777952CBDC01F1C2704BFFA84BDA4377A7283D4BD6AEBFD25239B85D4E7BFD7ED2BEDFD32077FB5F964A896E411852BCCEAD28DADD2783B9934871ADEAC73D4C3376D2EA96CDE4A523EA1753C2167B16B6FC8E5DD2EDFCE16771104B0788969718D34199CEEC81A0918478644599AD14957332230BD3FF3AEF891C6C479A40FAE4759237FF8B113FF6676372862377445C923042C7386FC2067798918E68D6D08573E72BD01F6F10E5C20905ABAA18F0BB57CA4E03588F456F2038A22D8C69C7FA1E869EB2A9E633B0EC1BB6ADADD1AB787274AF05DEC2FB8D3EE8ED7604BF3F80B9D219BD1F08AF0511BE3DD50FB2B8DD91571B8417F66765FFB2E000611E7C2B67114CDC098B13305576739E0356167A7BDE1F8BEBAEF386AEA21D7570752C209F025272D83293585145069C854415593A8B0D3B9A49BA839A95ED494A255D48CACAFA81CAC9BA419A55ED084A055CE946AB0303559A1E1E3D404F6F003D5CDA20DDD5E5051E31C7648FC032638846DCC79408CE190942BD065DFD84774932C1F67BAF5B329E1F423F2E2A159ADE50DC92630BC3724B087EF0D8998D0FCEC3A3C2AE9707BCB8901BE13BDFA62D8EE738264BB7687DA3477CD7C377B80CE5D2EA288DA6EE2058ABC5D9675A9CB0F319CD19E82496723A671606260E82E3FF2A005E6668A46754F2EB18719362EEC34AF3945918D1C598D3021A78760F989AA10AC4CE7D485FB87C4132C1D877C10E297A0083CD5254C760B97D86E80BC562D09233B1E617CEE050FB1E71207987086AD9AE8C25C9DBDE102147C844569D3D0D8AA585CB3216AA256DD9AB785B0E5BA4B49959DD8644BECACB1CB2C7EDB8A61366B6C07C6D9AC922E02683391FB30D0ECAED2D500C48BCBA119A87063D218681652EDC440EB1ADB8381D655F2E60C34BDA2765D7FE1BE7A68E659BF28EFFE586F54D71E6CB3A68F0333CD34F684310C46E05036CFCB05EFC42F4C71390339B3FB599485BAA28970F03966F5944D19EF2AE350AB194434A226C0D2D05A40B36F981290E4503D84CB73798DD26551440FD83CEFD6089BEDFD026CC50664ECEAB7DC0AA1FE8BAF689C9D6E1FC5CC0A6B908CBCD365A182A3300871F3AA4FBC835274795959315D62E13ED1706562D9623428A82572D528299FCCE05ACA4DB35D4BAA80AC4F48B6919684F049A3A57C32836B29B3D176252982821E61C1462AAA1FE103395B9EE9284E9BA26F6CA5855E59C3D8D254848D6F5110B86455A910CB5A8C795A1E36FD66DEBF62CA4F312C3B52144E15D2169C180DD10A0BBDC01A249DB961C42E11430BC4F33C53C797C89467AB66FBCF59568F4F7911F37320A7E63FA723B49507B513570E4932A419CCD3E7714D924C5758817AB8C1EBF690874245FE7E4ABDD827FA304B3F3AFD8A571D9FB6C808634B905F0AA3249D49C16E7D013A2D8FEC1A832E5511CBACBF5C7A089DD2F348B4AA765D74AA47C9935555145D026B6FCBA70B6AD65832316AECBF62AD08DBF131B1B6A68A24F675475595D0549155FDDDD1B3F29A2A60D6D413A352A1218155FABAA3D68B68AA98F59EEE8842A54C1552E8EA2165B51EA62664B5632D3C8D46D514DD39C815305574B9B787A5CAB530354395BBD7C056C82CF675475594CB548115DDDDB1CBDA1971FB3FE093577BFFDAF0E84D2FEA9B9DBD1A8CEDECE5C31CDD957A842A50A5B927565671208165ED076953DADBEA863695666936B3290D867E17AA7DCFAF6F428D45087ACCDA47FADA46DF54A4A0C7EB67B95BB50FE9CA2A9214DC8BABAB70451D67D7C5F6974DD2FD3125318D5C8D70C8BF460CFB234E309AFFEC4D3D17F32D3D27B845C45DE288A58529E6E9F1C9A9F02CEA709E285951E4788AEBB6EE9D527DCD765063469E51683FA150AEF8D8E0194F092A25D3AF89835F26E6AFC9A8F3242FC37F4A9A8F8CEBE833717F8EA1E3318CB1F19B5CC13ACCB386E6ABE2813E42E9AED5EBFF7E49871E19F72178CCB9712CE8729D15AE3F4DE9254D3A740369D67EB0F2761D4AFD022487FF9B8F5EFE5EC5DCEC958703913E4BAAE0FB21D65E7D28A72E78EDFA8F3C162E1BE481C7461A543EE2D80851F1506328BC4154A87B88B10E96F611C6BAE6A77E94B18E68DA07192EE90F263EC7E8BE57E623F7781E2AAE6FBBD837133DB796B36F54DBBAEF0354AA7ADFC8D1E5CAF61E701B54AFAF61196FACF07BB0235C51D73D18F63E4D7BEBC5DC8752BF5D56D6ECB76C7B9795DA0D5FE0FE5405DA075052A82891DA7F19F6AE6D4D97723EF05AD67EC5D607666C59E1DCFE4BAA776D6CBA5CF4811B5BAFC2E903B3B57D9D9F7BB6B4CE47E8DECBA0E58A2ECDA72355C2BAADCC39CDEEC30D7F41C108D288327D9DAAAEAB6BAA096E615892E899EA0BFA44C692E3487C258A66B6FDE69A1DF88D93CD689AD96ACA609B7867FB7F23EF8CA699B7A6B8741F05DACAF24E55D17CCB3ED6546FF6960AB26B3369A9FF6F8B591BEB00DE52FDF5204AA9798FE643F6DB29B71E442543BA4E8FF26AF99B349C9D95BFC909E777E4AE4A08FE173A09B66BA76641734D96343FBC058972122143738B1972E048BD0899BB4436836E9E634E9ED727793BFEA563819D6B721FB320663065EC2FBC5AC28B07014DFC931AF2BACCE3FB20F94B31434C01C474796EFE9E7C8C5DCF29E49E2972421A081E5D64195DBE968C677657AF05D21D251D8132F51541D123F6030FC0A27B3247CF781DD9C0FC6EF00AD9AF65065007D2BE1075B58F2F5DB40A911F6518E578F8156CD8F15FBEFB3FCFDCF7DE9A560000 , N'6.1.2-31219')
