"""
 Licensed to the Apache Software Foundation (ASF) under one
 or more contributor license agreements.  See the NOTICE file
 distributed with this work for additional information
 regarding copyright ownership.  The ASF licenses this file
 to you under the Apache License, Version 2.0 (the
 "License"); you may not use this file except in compliance
 with the License.  You may obtain a copy of the License at
     http://www.apache.org/licenses/LICENSE-2.0
 Unless required by applicable law or agreed to in writing,
 software distributed under the License is distributed on an
 "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 KIND, either express or implied.  See the License for the
 specific language governing permissions and limitations
 under the License.
"""

import sys
import os
from setuptools import setup, find_packages

"""
Setup module for oss util.
Created on 3/24/2020
@author: Alibaba Cloud
"""

PACKAGE = "alibabacloud_oss_util"
DESCRIPTION = "The oss util module of alibabaCloud Python2 SDK."
AUTHOR = "Alibaba Cloud"
AUTHOR_EMAIL = "alibaba-cloud-sdk-dev-team@list.alibaba-inc.com"
URL = "https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/util/python2"
TOPDIR = os.path.dirname(__file__) or "."
VERSION = __import__(PACKAGE).__version__

if sys.version_info.major == 2:
    with open("README.md") as fp:
        LONG_DESCRIPTION = fp.read()
else:
    with open("README.md", encoding='utf-8') as fp:
        LONG_DESCRIPTION = fp.read()


setup_args = {
    'version': VERSION,
    'description': DESCRIPTION,
    'long_description': LONG_DESCRIPTION,
    'author': AUTHOR,
    'author_email': AUTHOR_EMAIL,
    'license': "Apache License 2.0",
    'url': URL,
    'keywords': ["alibabacloud", "sdk", "tea"],
    'packages': find_packages(exclude=["tests*"]),
    'platforms': 'any',
    'install_requires': ['alibabacloud-tea-py2'],
    'classifiers': (
        'Development Status :: 5 - Production/Stable',
        'Intended Audience :: Developers',
        'License :: OSI Approved :: Apache Software License',
        'Programming Language :: Python :: 2',
        'Programming Language :: Python :: 2.7',
        'Topic :: Software Development',
    )
}

setup(name='alibabacloud_oss_util_py2', **setup_args)
