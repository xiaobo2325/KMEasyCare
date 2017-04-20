SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `LTC_IPDORDER`  医嘱表
-- ----------------------------
DROP TABLE IF EXISTS `LTC_IPDORDER`;
CREATE TABLE `LTC_IPDORDER` (
  `ORDERNO` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '医嘱号',
  `ORDERTYPE` int(11) DEFAULT NULL COMMENT '嘱型 1.长嘱 2.临嘱',
  `FEECODE` int(11) DEFAULT NULL COMMENT '医嘱代码（收费项目代码） 套餐：只记录套餐ID',
  `ITEMTYPE` int(11) DEFAULT NULL COMMENT '收费项目类别（药品，诊疗，服务，套餐）',
  `ACREMARK` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '医生嘱托',
  `TAKEQTY` decimal(18,2) DEFAULT NULL COMMENT '单次用量（剂量）',
  `TAKEDAY` int(11) DEFAULT NULL COMMENT '天数',
  `TAKEFREQ` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '执行频率（ltc_drugfreqref）',
  `TAKEWAY` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '途径',
  `CONFIRMFLAG` int(11) DEFAULT 0 COMMENT '审核标记 0.未审核 1.已审核',
  `CONFIRMDATE` datetime DEFAULT NULL COMMENT '审核日期',
  `CHECKFLAG` int(11) DEFAULT 0 COMMENT '校对标记 0.未校对 1.已校对',
  `CHECKDATE` datetime DEFAULT NULL COMMENT '校对时间',
  `STOPFLAG` int(11) DEFAULT 0 COMMENT '停止标记 0.未停止 1.结束日期到期自动停止 2.医生强制停止 3.结案停止',
  `STOPDATE` datetime DEFAULT NULL COMMENT '停嘱时间',
  `STOPCHECKFLAG` int(11) DEFAULT 0 COMMENT '停止确认标记 0.未停止 1.确认停止',
  `STOPCHECKDATE` datetime DEFAULT NULL COMMENT '停止确认日期',
  `STARTDATE` datetime DEFAULT NULL COMMENT '开始执行时间',
  `ENDDATE` datetime DEFAULT NULL COMMENT '执行终止时间',
  `EXECTIMES` int(11) DEFAULT 0 COMMENT '执行次数',
  `BILLDATE` datetime DEFAULT NULL COMMENT '开嘱时间',
  `DELETEFLAG` int(11) DEFAULT 0 COMMENT '作废标记',
  `FIRSTDAYQUANTITY` int(11) DEFAULT '-1' COMMENT '首日量(发送次数)-1 按默认（执行一次） 0.不产生首日量 2.执行两次',
  `SORTNUMBER` bigint(20) DEFAULT NULL COMMENT '排序号',
  `CHARGEGROUPID` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '套餐ID',
  `DOCTORNO` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '开立医生',
  `NURSENO` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '校对护士',
  `FEENO` bigint(20) DEFAULT NULL COMMENT '入住号', 
  `REGNO` int(11) DEFAULT NULL COMMENT '住民号',
  `ORGID` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '机构ID',
  `CREATEBY` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '创建人',
  `CREATETIME` datetime DEFAULT NULL COMMENT '创建时间',
  `UPDATEBY` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '修改人',
  `UPDATETIME` datetime DEFAULT NULL COMMENT '修改时间',
  `ISDELETE` tinyint(1) DEFAULT 0 COMMENT '删除标记',
  PRIMARY KEY (`ORDERNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Table structure for `LTC_IPDORDERPOSTREC`  医嘱发送记录表
-- ----------------------------
DROP TABLE IF EXISTS `LTC_IPDORDERPOSTREC`;
CREATE TABLE `LTC_IPDORDERPOSTREC` (
  `ORDERPOSTRECNO` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '医嘱发送记录号',
  `ORDERNO` bigint(20) DEFAULT NULL COMMENT '医嘱号',
  `POSTDATE` datetime DEFAULT NULL COMMENT '发送时间',
  `NURSENO` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '执行护士',
  `CREATEBY` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '创建人',
  `CREATETIME` datetime DEFAULT NULL COMMENT '创建时间',
  `UPDATEBY` varchar(32) COLLATE utf8_bin DEFAULT NULL COMMENT '修改人',
  `UPDATETIME` datetime DEFAULT NULL COMMENT '修改时间',
  `ISDELETE` tinyint(1) DEFAULT 0 COMMENT '删除标记',
  PRIMARY KEY (`ORDERPOSTRECNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--使用记录表添加医嘱明细号（区分是否从医嘱生成）
ALTER TABLE `LTC_DRUGRECORD` ADD COLUMN `ORDERNO`  bigint(20) NULL DEFAULT NULL COMMENT '医嘱号' AFTER `DRUGRECORDID`;

ALTER TABLE `LTC_MATERIALRECORD` ADD COLUMN `ORDERNO`  bigint(20) NULL DEFAULT NULL COMMENT '医嘱号' AFTER `MATERIALRECORDID`;

ALTER TABLE `LTC_SERVICERECORD`
ADD COLUMN `ORDERNO`  bigint(20) NULL DEFAULT NULL COMMENT '医嘱号' AFTER `SERVICERECORDID`;

--模块表 费用录入修改为批价作业 新增两个模块 医嘱开立(医生使用)和医嘱发送（护理人员使用）  医嘱开立和医嘱发送明细待定
UPDATE `LTC_MODULES` SET `MODULENAME`='批价作业' WHERE (`MODULEID`='1701');
INSERT INTO `LTC_MODULES` (`MODULEID`, `MODULENAME`, `URL`, `DESCRIPTION`, `SUPERMODULEID`, `TARGET`, `ICON`, `CREATEBY`, `STATUS`, `SYSTYPE`) VALUES ('1711', '医嘱开立', '/angular/DocOrder/', '', '17', '2', '', '', '1', 'LC');
INSERT INTO `LTC_MODULES` (`MODULEID`, `MODULENAME`, `URL`, `DESCRIPTION`, `SUPERMODULEID`, `TARGET`, `ICON`, `CREATEBY`, `STATUS`, `SYSTYPE`) VALUES ('1712', '医嘱发送', '/angular/NurSendOrder/', '', '17', '2', '', '', '1', 'LC');


INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.017', '医嘱停用状态');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.018', '医嘱审核状态');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.019', '医嘱校对状态');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.020', '医嘱日期条件');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.021', '医嘱类型');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.022', '医嘱首日量');
INSERT INTO `LTC_CODEFILE_REF` (`ITEMTYPE`, `TYPENAME`) VALUES ('C00.023', '医嘱作废状态');

INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('001', 'C00.017', '正常', '医嘱停用状态', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('002', 'C00.017', '停用', '医嘱停用状态', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('003', 'C00.017', '全部', '医嘱停用状态', '3');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('001', 'C00.018', '全部', '医嘱审核状态', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('002', 'C00.018', '已审核', '医嘱审核状态', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('003', 'C00.018', '未审核', '医嘱审核状态', '3');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('001', 'C00.019', '全部', '医嘱校对状态', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('002', 'C00.019', '已校对', '医嘱校对状态', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('003', 'C00.019', '未校对', '医嘱校对状态', '3');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('001', 'C00.020', '全部日期', '医嘱日期条件', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('002', 'C00.020', '选择日期', '医嘱日期条件', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('1', 'C00.021', '长嘱', '医嘱类型', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('2', 'C00.021', '临嘱', '医嘱类型', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('-1', 'C00.022', '正常发送', '医嘱首日量', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('0', 'C00.022', '不产生', '医嘱首日量', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('2', 'C00.022', '执行两次', '医嘱首日量', '3');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('001', 'C00.023', '全部', '医嘱作废状态', '1');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('002', 'C00.023', '已作废', '医嘱作废状态', '2');
INSERT INTO `LTC_CODEDTL_REF` (`ITEMCODE`, `ITEMTYPE`, `ITEMNAME`, `DESCRIPTION`, `ORDERSEQ`) VALUES ('003', 'C00.023', '未作废', '医嘱作废状态', '3');


INSERT INTO `LTC_DRGFREQREF` (`FREQNO`, `FREQNAME`, `FREQHOUR`, `FREQDAY`, `FREQQTY`, `FREQMOR`, `FREQNOON`, `FREQEVE`, `FREQSLEEP`, `FREQMEAL`, `FREQTIME`, `FREQPRN`, `FREQFLG`, `FREQWEEK`, `STATEFLAG`, `CREATEID`, `CREATETIME`, `UPDATEID`, `UPDATETIME`) VALUES ('ONCE', '每天使用一次', '0', '1', '1', '1', '0', '0', '0', '0', NULL, '0', 'Y', NULL, '1', NULL, NULL, NULL, NULL);
