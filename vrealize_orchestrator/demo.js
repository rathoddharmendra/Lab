/** Copyright © 2020 Dell Inc. or its subsidiaries. All Rights Reserved. */
if(storageSystem == null || nfsShare == null || localPath == null) {
	throw "Either storage system or name of NFS share or path is not set."
}

if(hostSelection === "By selecting the host from host list"){
	var hostList = UnityEsxiHostManager.getAllHostsListExceptRecoveryPoint(storageSystem);
	var noAccessHostIds = getIdOfHost(noAccessHosts);
	var readHostIds = getIdOfHost(readOnlyHosts);
	var readWriteHostIds = getIdOfHost(readWriteHosts);
	var readRootHostIds = getIdOfHost(readOnlyRootAccessHosts);
	var readWriteRootHostIds = getIdOfHost(readWriteRootAccessHosts);
}
var requestBody = {};
var nfsShareCreate = {};
var nfsShareCreates = []
if(createNFSUsingSnapshot == "Yes") {
	requestBody.name = nfsShare;
	requestBody.path = localPath;
	requestBody.snap = {};
	requestBody.snap.name = snapshots;
} else {
	nfsShareCreate.name = nfsShare;
	nfsShareCreate.path = localPath;
}

nfsShareCreate.nfsShareParameters = {};
if(createNFSUsingSnapshot == "No") {
	nfsShareCreate.nfsShareParameters.description = description;
	nfsShareCreate.nfsShareParameters.anonymousUID = anonymousUID;
	nfsShareCreate.nfsShareParameters.anonymousGID = anonymousGID;
	nfsShareCreate.nfsShareParameters.defaultAccess = getDefaultAccessEnum(defaultAccess);
} else {
	requestBody.description = description;
	requestBody.defaultAccess = getDefaultAccessEnum(defaultAccess);
}
if(createNFSUsingSnapshot == "No") {
	if(suid){
                // This will enable SUID of NFS Share
		nfsShareCreate.nfsShareParameters.exportOption = 0;
	} else {
                // This will disable SUID  of NFS Share
		nfsShareCreate.nfsShareParameters.exportOption = 2;
	}
}

if(hostSelection === "By selecting the host from host list") {
	if(noAccessHostIds != null && noAccessHostIds.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.noAccessHosts = updateHostArray(noAccessHostIds);
	} else if(noAccessHostIds != null && noAccessHostIds.length > 0){
		requestBody.noAccessHosts = updateHostArray(noAccessHostIds);
	}

	if(readHostIds != null && readHostIds.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readOnlyHosts = updateHostArray(readHostIds);
	} else if(readHostIds != null && readHostIds.length > 0){
		requestBody.readOnlyHosts = updateHostArray(readHostIds);
	}

	if(readWriteHostIds != null && readWriteHostIds.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readWriteHosts = updateHostArray(readWriteHostIds);
	} else if(readWriteHostIds != null && readWriteHostIds.length > 0){
		requestBody.readWriteHosts = updateHostArray(readWriteHostIds);
	}

	if(readRootHostIds != null && readRootHostIds.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readOnlyRootAccessHosts = updateHostArray(readRootHostIds);
	} else if(readRootHostIds != null && readRootHostIds.length > 0){
		requestBody.readOnlyRootAccessHosts = updateHostArray(readRootHostIds);
	}

	if(readWriteRootHostIds != null && readWriteRootHostIds.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.rootAccessHosts = updateHostArray(readWriteRootHostIds);
	} else if(readWriteRootHostIds != null && readWriteRootHostIds.length > 0){
		requestBody.rootAccessHosts = updateHostArray(readWriteRootHostIds);
	}
} else if(hostSelection === "By Entering the Host") {
	if(noAccessString != null && noAccessString.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.noAccessHostsString = getHostString(noAccessString);
	} else if(noAccessString != null && noAccessString.length > 0){
		requestBody.noAccessHostsString = getHostString(noAccessString);
	}

	if(readOnlyString != null && readOnlyString.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readOnlyHostsString = getHostString(readOnlyString);
	} else if(readOnlyString != null && readOnlyString.length > 0){
		requestBody.readOnlyHostsString = getHostString(readOnlyString);
	}

	if(readWriteString != null && readWriteString.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readWriteHostsString = getHostString(readWriteString);
	} else if(readWriteString != null && readWriteString.length > 0){
		requestBody.readWriteHostsString = getHostString(readWriteString);
	}

	if(readOnlyRootString != null && readOnlyRootString.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readOnlyRootHostsString = getHostString(readOnlyRootString);
	} else if(readOnlyRootString != null && readOnlyRootString.length > 0){
		requestBody.readOnlyRootHostsString = getHostString(readOnlyRootString);
	}

	if(readWriteRootString != null && readWriteRootString.length > 0 && createNFSUsingSnapshot == "No"){
		nfsShareCreate.nfsShareParameters.readWriteRootHostsString = getHostString(readWriteRootString);
	} else if(readWriteRootString != null && readWriteRootString.length > 0){
		requestBody.readWriteRootHostsString = getHostString(readWriteRootString);
	}
}

function updateHostArray(hosts) {
	var jsonArray = [];
	for(var i = 0; i< hosts.length;i++){
		var noAccessHost = {};
		noAccessHost.id = hosts[i];
		jsonArray.push(noAccessHost);
	}
	return jsonArray;
}
if(createNFSUsingSnapshot == "No") {
	nfsShareCreates.push(nfsShareCreate);
	requestBody.nfsShareCreate = nfsShareCreates;
}

if(createNFSUsingSnapshot == "Yes") {
	nfsShareDetails = System.getModule("com.dell.unity.nfs").createNFSShare(storageSystem,nasServer,fileSystem,requestBody,true);
} else {
	nfsShareDetails = System.getModule("com.dell.unity.nfs").createNFSShare(storageSystem,nasServer,fileSystem,requestBody,false);
}

function getDefaultAccessEnum(defaultAccess) {
	switch(defaultAccess){
		case "No Access":
			return 0;
		case "Read-Only":
			return 1;
		case "Read/Write":
			return 2;
		case "Read/Write, allow Root":
			return 3;
		case "Read-only, allow Root":
			return 4;
		}
}

function getHostString(hosts){
	var hostString = "";
	if(hosts!=null){
		hostString = hosts.join();
	}
	return hostString;
}

function getIdOfHost(hosts){
	var ids = [];
	if(hosts!=null){
		for(var i =0; i < hosts.length;i++) {
		var host=hosts[i];
		var address = "";
			if(host.indexOf("(") > -1){
				var splitdata = host.substr(0, host.indexOf("("));
				address = host.split("(")[1];
				host = host.split("(")[0];
				address = address.substr(0, address.length - 1);
			}
			for(var j =0; j < hostList.length;j++) {
				var hostDetails = hostList[j];
				if(host.indexOf("(") > -1){
					if(hostDetails.name == host && hostDetails[0] == address) {
							ids.push(hostDetails.id);
							break;
					}
				} else {
					if(hostDetails.name == host) {
							ids.push(hostDetails.id);
							break;
					}
				}
			}
		}
	}
	return ids;
}